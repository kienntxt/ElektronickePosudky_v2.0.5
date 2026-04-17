using System.Globalization;
using ElektronickePosudky.Application.Localization;

namespace ElektronickePosudky.API.Middleware
{
    public sealed class AcceptLanguageMiddleware : IMiddleware
    {
        public const string HeaderName = "Accept-Language";

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var acceptLanguage = context.Request.Headers[HeaderName].ToString();
            var culture = ResolveRequestCulture(acceptLanguage);

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            await next(context);
        }

        private static CultureInfo ResolveRequestCulture(string acceptLanguage)
        {
            var defaultCulture = new CultureInfo(DefaultLocalizationOptions.DefaultCultureName);

            if (string.IsNullOrWhiteSpace(acceptLanguage))
                return defaultCulture;

            try
            {
                var languages = ParseAcceptLanguage(acceptLanguage);

                foreach (var lang in languages)
                {
                    // Try exact match first
                    var exactMatch = DefaultLocalizationOptions.SupportedCultures.FirstOrDefault(
                        c => c.Equals(lang, StringComparison.OrdinalIgnoreCase)
                    );
                    if (exactMatch != null)
                        return new CultureInfo(exactMatch);

                    // Try 2-letter fallback (e.g., "en" -> "en-US", "cs" -> "cs-CZ")
                    var twoLetterCode = lang.Split('-')[0];
                    var twoLetterMatch =
                        DefaultLocalizationOptions.SupportedCultures.FirstOrDefault(c =>
                            c.StartsWith(twoLetterCode, StringComparison.OrdinalIgnoreCase)
                        );
                    if (twoLetterMatch != null)
                        return new CultureInfo(twoLetterMatch);
                }
            }
            catch (Exception)
            {
                // Silently fallback to default on any error
            }

            return defaultCulture;
        }

        private static IEnumerable<string> ParseAcceptLanguage(string acceptLanguage)
        {
            return acceptLanguage
                .Split(',')
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x =>
                {
                    var parts = x.Split(';');
                    var lang = parts[0].Trim();
                    var quality = 1.0;

                    if (parts.Length > 1 && parts[1].Contains("q="))
                    {
                        var qParam = parts[1].Split('=');
                        if (qParam.Length > 1 && double.TryParse(qParam[1], out var q))
                        {
                            quality = q;
                        }
                    }

                    return (language: lang, quality);
                })
                .OrderByDescending(x => x.quality)
                .Select(x => x.language);
        }
    }
}

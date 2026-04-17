namespace ElektronickePosudky.Application.Localization
{
    public sealed class DefaultLocalizationOptions
    {
        public const string DefaultCultureName = "en-US";

        public static readonly string[] SupportedCultures = ["en-US", "cs-CZ"];

        public const bool FallbackToAny = false;
    }
}

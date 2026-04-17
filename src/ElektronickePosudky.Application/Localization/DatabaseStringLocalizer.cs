using System.Globalization;
using ElektronickePosudky.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;

namespace ElektronickePosudky.Application.Localization;

public sealed class DatabaseStringLocalizer : IStringLocalizer
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public DatabaseStringLocalizer(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public LocalizedString this[string name]
    {
        get
        {
            var value = GetString(name);
            return new LocalizedString(name, value ?? name, value == null);
        }
    }

    public LocalizedString this[string name, params object[] arguments]
    {
        get
        {
            var format = GetString(name);
            var value = format != null ? string.Format(format, arguments) : name;
            return new LocalizedString(name, value, format == null);
        }
    }

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
    {
        var context = GetContext();
        var currentCulture = CultureInfo.CurrentCulture.Name;
        var translations = context
            .Translations.Where(t => t.Language == currentCulture)
            .Select(t => new LocalizedString(
                $"{t.EntityType}.{t.EntityId}.{t.PropertyName}",
                t.Value,
                false
            ))
            .ToList();

        return translations;
    }

    private string? GetString(string name)
    {
        var context = GetContext();
        var currentCulture = CultureInfo.CurrentCulture.Name;

        // Parse the key format: EntityType.EntityId.PropertyName
        var parts = name.Split('.');
        if (parts.Length != 3)
        {
            return null;
        }

        if (!Guid.TryParse(parts[1], out var entityId))
        {
            return null;
        }

        var translation = context.Translations.FirstOrDefault(t =>
            t.EntityType == parts[0]
            && t.EntityId == entityId
            && t.PropertyName == parts[2]
            && t.Language == currentCulture
        );

        return translation?.Value;
    }

    private IElektronickePosudkyContext GetContext()
    {
        return _httpContextAccessor.HttpContext?.RequestServices.GetRequiredService<IElektronickePosudkyContext>()
            ?? throw new InvalidOperationException(
                "Unable to resolve database context from current request."
            );
    }
}

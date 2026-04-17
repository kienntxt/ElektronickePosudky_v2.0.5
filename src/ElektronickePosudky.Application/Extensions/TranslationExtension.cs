using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Domain.Entities;

namespace ElektronickePosudky.Application.Extensions;

public static class TranslationExtension
{
    public static string? GetLocalizedValue(
        this ICollection<Translation>? translations,
        string propertyName,
        string cultureName,
        string defaultCulture = "en",
        bool fallbackToAny = false
    )
    {
        if (translations == null || string.IsNullOrEmpty(propertyName))
        {
            return null;
        }

        // Try required culture first
        var translation = translations.FirstOrDefault(t =>
            t.PropertyName == propertyName && t.Language == cultureName
        );

        if (translation != null)
        {
            return translation.Value;
        }

        // Fallback to default culture
        translation = translations.FirstOrDefault(t =>
            t.PropertyName == propertyName && t.Language == defaultCulture
        );

        if (translation != null)
        {
            return translation.Value;
        }

        // Fallback to any available translation
        if (fallbackToAny)
        {
            translation = translations.FirstOrDefault(t => t.PropertyName == propertyName);
        }
        return translation?.Value;
    }

    public static IDictionary<string, TranslationDto>? ConvertTranslations(
        this ICollection<Translation>? translations,
        string cultureName,
        string defaultCulture = "en",
        bool fallbackToAny = false
    )
    {
        if (translations == null)
        {
            return null;
        }

        return translations
            .GroupBy(t => t.PropertyName)
            .ToDictionary(
                g => g.Key,
                g => new TranslationDto
                {
                    Nazev = g.Key,
                    Popis = GetLocalizedValue(
                        translations,
                        g.Key,
                        cultureName,
                        defaultCulture: defaultCulture,
                        fallbackToAny: fallbackToAny
                    ),
                }
            );
    }
}

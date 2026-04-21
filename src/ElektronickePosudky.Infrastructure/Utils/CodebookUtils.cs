using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using ElektronickePosudky.Domain.Entities;

namespace ElektronickePosudky.Infrastructure.Utils
{
    public static class CodebookUtils
    {
        private static readonly Dictionary<
            string,
            (string kod, string nazev, string popis, string name, string description)
        > _ciselnikMap = new()
        {
            {
                "elp-ro-akce",
                (
                    kod: "akce-ro",
                    nazev: "Typ akce",
                    popis: "Typ akce s posudkem",
                    name: "Type of action",
                    description: "Type of action with certificate"
                )
            },
            {
                "elp-ro-druh-posudku",
                (
                    kod: "druh-posudku-ro",
                    nazev: "Druh posudku",
                    popis: "Typ lékařského posudku",
                    name: "Type of report",
                    description: "Type of medical report"
                )
            },
            {
                "elp-ro-druh-prohlidky",
                (
                    kod: "druh-prohlidky-ro",
                    nazev: "Druh prohlídky",
                    popis: "Typ lékařské prohlídky",
                    name: "Type of examination",
                    description: "Type of medical examination"
                )
            },
            {
                "elp-ro-harmonizovane-kody",
                (
                    kod: "seznam-harmonizovane-kody-ro",
                    nazev: "Harmonizovane kódy",
                    popis: "Harmonizované kódy pro omezení Mas",
                    name: "Harmonised codes",
                    description: "Harmonised codes for the restriction of Mas"
                )
            },
            {
                "elp-ro-narodni-kody",
                (
                    kod: "seznam-narodni-kody-ro",
                    nazev: "Národní kódy",
                    popis: "Národní kódy pro omezení MA",
                    name: "National codes",
                    description: "National codes for MA restrictions"
                )
            },
            {
                "elp-ro-seznam-skupin",
                (
                    kod: "seznam-skupin-ro",
                    nazev: "Seznam skupin",
                    popis: "Seznam skupin",
                    name: "List of groups",
                    description: "Driving License Groups"
                )
            },
            {
                "elp-ro-stav-posudku",
                (
                    kod: "stav-posudku",
                    nazev: "Stav posudku",
                    popis: "Stav lékařského posudku",
                    name: "Medical Opinion Status",
                    description: "Medical Opinion Status"
                )
            },
            {
                "elp-ro-vysledek-posudku",
                (
                    kod: "vysledek-posudku-ro",
                    nazev: "Výsledek",
                    popis: "Výsledek lékařského posudku",
                    name: "Result",
                    description: "Medical conclusion, competence."
                )
            },
            {
                "elp-ro-zadatel-skupina",
                (
                    kod: "skupina-zadatel-ridic-ro",
                    nazev: "Skupina žadatele řidič",
                    popis: "Skupina řidičského oprávnění",
                    name: "Driver applicant group",
                    description: "Group of applicants, holders of driving licences"
                )
            },
        };

        private static Dictionary<string, string> _languages = new Dictionary<string, string>
        {
            { "cs", "cs-CZ" },
            { "cs-cz", "cs-CZ" },
            { "en", "en-US" },
            { "en-us", "en-US" },
        };

        private static string ResolveLanguage(string key)
        {
            string lowerKey = key.ToLower();
            return _languages.ContainsKey(lowerKey) ? _languages[lowerKey] : "en-US";
        }

        private static JsonCodebook? Load(string fileName)
        {
            string filePath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!,
                "codelists",
                fileName
            );

            using (var stream = new StreamReader(filePath, Encoding.UTF8).BaseStream)
            {
                return JsonSerializer.Deserialize<JsonCodebook>(stream);
            }
        }

        public static CodebookResult ParseJsonCodebook(string fileName, CiselnikType ciselnikType)
        {
            var jsonCodebook = Load(fileName);
            if (jsonCodebook == null)
                throw new InvalidOperationException($"Failed to parse json file {fileName}");

            var code = new Ciselnik
            {
                Id = GuidUtils.Generate(GuidUtils.CiselnikPrefix, jsonCodebook.id, ciselnikType),
                Kod = _ciselnikMap[jsonCodebook.valueSet].kod,
                Verze = jsonCodebook.version,
                PlatnostOd = jsonCodebook.releaseDate,
            };

            int translationStartId = 0;
            var translations = new List<Translation>
            {
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        ciselnikType
                    ),
                    EntityType = "Ciselnik",
                    EntityId = code.Id,
                    PropertyName = "Nazev",
                    Language = "cs-CZ",
                    Value = _ciselnikMap[jsonCodebook.valueSet].nazev,
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        ciselnikType
                    ),
                    EntityType = "Ciselnik",
                    EntityId = code.Id,
                    PropertyName = "Popis",
                    Language = "cs-CZ",
                    Value = _ciselnikMap[jsonCodebook.valueSet].popis,
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        ciselnikType
                    ),
                    EntityType = "Ciselnik",
                    EntityId = code.Id,
                    PropertyName = "Nazev",
                    Language = "en-US",
                    Value = _ciselnikMap[jsonCodebook.valueSet].name,
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        ciselnikType
                    ),
                    EntityType = "Ciselnik",
                    EntityId = code.Id,
                    PropertyName = "Popis",
                    Language = "en-US",
                    Value = _ciselnikMap[jsonCodebook.valueSet].description,
                },
            };

            bool duplicatedId = jsonCodebook
                .snapshot.expansion.Select(x => x.display)
                .GroupBy(d => d.id)
                .Any(g => g.Count() > 1);
            int polozkaStartId = 0;

            var items = jsonCodebook
                .snapshot.expansion.Select(x => new KeyValuePair<string, CiselnikPolozka>(
                    x.concept.code,
                    new CiselnikPolozka
                    {
                        Id = GuidUtils.Generate(
                            GuidUtils.CiselnikPolozkaPrefix,
                            !duplicatedId ? x.display.id : ++polozkaStartId,
                            ciselnikType
                        ),
                        CiselnikId = code.Id,
                        CiselnikKod = code.Kod,
                        CiselnikVerze = code.Verze,
                        Kod = x.concept.code,
                        Verze = code.Verze,
                    }
                ))
                .ToDictionary();

            //only 1 "Display"
            translations.AddRange(
                jsonCodebook.snapshot.expansion.Select(x => new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        ciselnikType
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = items[x.concept.code].Id,
                    PropertyName = "Nazev",
                    Language = ResolveLanguage(x.display.language),
                    Value = x.display.name,
                })
            );

            //more than 1 "Designations"
            translations.AddRange(
                jsonCodebook.snapshot.expansion.SelectMany(x =>
                    //sort by "preferred" then get last to avoid duplications
                    x.additionalDesignations.GroupBy(d => d.language, d => d)
                        .Select(g => g.OrderBy(o => o.preferred).Last())
                        .Select(a => new Translation
                        {
                            Id = GuidUtils.Generate(
                                GuidUtils.TranslationPrefix,
                                ++translationStartId,
                                ciselnikType
                            ),
                            EntityType = "CiselnikPolozka",
                            EntityId = items[x.concept.code].Id,
                            PropertyName = "Popis",
                            Language = ResolveLanguage(a.language),
                            Value = a.name,
                        })
                )
            );

            return new CodebookResult(code, items.Values.ToList(), translations);
        }

        public static CodebookResult GenerateOdbnornost()
        {
            var now = DateTime.UtcNow;
            //Medical Specialty (odbnornost)
            var odbornostCiselnik = new Ciselnik
            {
                Id = GuidUtils.Generate(GuidUtils.CiselnikPrefix, 1, CiselnikType.Odbnornost),
                Kod = "odbnornost",
                Verze = "1.0.0",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };

            var interniLekarItem = new CiselnikPolozka
            {
                Id = GuidUtils.Generate(
                    GuidUtils.CiselnikPolozkaPrefix,
                    1,
                    CiselnikType.Odbnornost
                ),
                CiselnikId = odbornostCiselnik.Id,
                Kod = "interni",
                Verze = "1.0.0",
                CiselnikKod = odbornostCiselnik.Kod,
                CiselnikVerze = odbornostCiselnik.Verze,
            };

            var okulistaItem = new CiselnikPolozka
            {
                Id = GuidUtils.Generate(
                    GuidUtils.CiselnikPolozkaPrefix,
                    2,
                    CiselnikType.Odbnornost
                ),
                CiselnikId = odbornostCiselnik.Id,
                Kod = "okulista",
                Verze = "1.0.0",
                CiselnikKod = odbornostCiselnik.Kod,
                CiselnikVerze = odbornostCiselnik.Verze,
            };

            var items = new List<CiselnikPolozka> { interniLekarItem, okulistaItem };

            int translationStartId = 0;

            var translations = new List<Translation>
            {
                // ODBNORNOST Ciselnik
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "Ciselnik",
                    EntityId = odbornostCiselnik.Id,
                    Language = "cs-CZ",
                    PropertyName = "Nazev",
                    Value = "Odbornost",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "Ciselnik",
                    EntityId = odbornostCiselnik.Id,
                    Language = "cs-CZ",
                    PropertyName = "Popis",
                    Value = "Lékařská odbornost",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "Ciselnik",
                    EntityId = odbornostCiselnik.Id,
                    Language = "en-US",
                    PropertyName = "Nazev",
                    Value = "Specialty",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "Ciselnik",
                    EntityId = odbornostCiselnik.Id,
                    Language = "en-US",
                    PropertyName = "Popis",
                    Value = "Medical specialty",
                },
                // INTERNI Item
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = interniLekarItem.Id,
                    Language = "cs-CZ",
                    PropertyName = "Nazev",
                    Value = "Interní lékař",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = interniLekarItem.Id,
                    Language = "cs-CZ",
                    PropertyName = "Popis",
                    Value = "Lékař interního lékařství",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = interniLekarItem.Id,
                    Language = "en-US",
                    PropertyName = "Nazev",
                    Value = "Internal medicine",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = interniLekarItem.Id,
                    Language = "en-US",
                    PropertyName = "Popis",
                    Value = "Internal medicine physician",
                },
                // OKULISTA Item
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = okulistaItem.Id,
                    Language = "cs-CZ",
                    PropertyName = "Nazev",
                    Value = "Oční lékař",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = okulistaItem.Id,
                    Language = "cs-CZ",
                    PropertyName = "Popis",
                    Value = "Oční lékař (oftalmolog)",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = okulistaItem.Id,
                    Language = "en-US",
                    PropertyName = "Nazev",
                    Value = "Ophthalmologist",
                },
                new Translation
                {
                    Id = GuidUtils.Generate(
                        GuidUtils.TranslationPrefix,
                        ++translationStartId,
                        CiselnikType.Odbnornost
                    ),
                    EntityType = "CiselnikPolozka",
                    EntityId = okulistaItem.Id,
                    Language = "en-US",
                    PropertyName = "Popis",
                    Value = "Eye physician (ophthalmologist)",
                },
            };

            return new CodebookResult(odbornostCiselnik, items, translations);
        }
    }
}

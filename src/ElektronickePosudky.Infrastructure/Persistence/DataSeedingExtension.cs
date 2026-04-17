using ElektronickePosudky.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Infrastructure.Persistence
{
    public static class DataSeedingExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var now = DateTime.UtcNow;

            // Ciselniks and CiselnikPolozkas with Translations
            var codebooks = new List<Ciselnik>();
            var codebookItems = new List<CiselnikPolozka>();
            var translations = new List<Translation>();

            // 1. PosudekRo Status (STAV-RO)
            var stavRoCiselnik = new Ciselnik
            {
                Id = Guid.Parse("a14bffda-1149-4ec5-b79d-cdda839259c1"),
                Kod = "STAV-RO",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(stavRoCiselnik);

            var platnyItem = new CiselnikPolozka
            {
                Id = Guid.Parse("91c091e9-2d8a-454a-952e-61a37a6daa0c"),
                CiselnikId = stavRoCiselnik.Id,
                Kod = "PLATNY",
                Verze = "1",
                CiselnikKod = stavRoCiselnik.Kod,
                CiselnikVerze = stavRoCiselnik.Verze,
            };
            codebookItems.Add(platnyItem);

            var zneplatnenyItem = new CiselnikPolozka
            {
                Id = Guid.Parse("06cefa04-8612-4dcf-b196-46d435f1718b"),
                CiselnikId = stavRoCiselnik.Id,
                Kod = "ZNEPLATNENY",
                Verze = "1",
                CiselnikKod = stavRoCiselnik.Kod,
                CiselnikVerze = stavRoCiselnik.Verze,
            };
            codebookItems.Add(zneplatnenyItem);

            translations.AddRange(
                new[]
                {
                    // STAV-RO Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = stavRoCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Stav posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = stavRoCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Stav lékařského posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = stavRoCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Certificate status",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = stavRoCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "State of the medical certificate",
                    },
                    // PLATNY Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = platnyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Platný",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = platnyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Posudek je platný.",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = platnyItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Valid",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = platnyItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "The certificate is valid.",
                    },
                    // ZNEPLATNENY Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatnenyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Zneplatněný",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatnenyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Posudek byl zneplatněn.",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatnenyItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Invalidated",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatnenyItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "The certificate has been invalidated.",
                    },
                }
            );

            // 2. Type of Examination (DRUH-PROHLIDKY)
            var druhProhlidkyCiselnik = new Ciselnik
            {
                Id = Guid.NewGuid(),
                Kod = "DRUH-PROHLIDKY",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(druhProhlidkyCiselnik);

            var vychoziProhlidkaItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = druhProhlidkyCiselnik.Id,
                Kod = "VYCHOZI",
                Verze = "1",
                CiselnikKod = druhProhlidkyCiselnik.Kod,
                CiselnikVerze = druhProhlidkyCiselnik.Verze,
            };
            codebookItems.Add(vychoziProhlidkaItem);

            var periodickaProhlidkaItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = druhProhlidkyCiselnik.Id,
                Kod = "PERIODICKA",
                Verze = "1",
                CiselnikKod = druhProhlidkyCiselnik.Kod,
                CiselnikVerze = druhProhlidkyCiselnik.Verze,
            };
            codebookItems.Add(periodickaProhlidkaItem);

            translations.AddRange(
                new[]
                {
                    // DRUH-PROHLIDKY Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhProhlidkyCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Druh prohlídky",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhProhlidkyCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Typ lékařské prohlídky",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhProhlidkyCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Type of examination",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhProhlidkyCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Type of medical examination",
                    },
                    // VYCHOZI Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vychoziProhlidkaItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Výchozí prohlídka",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vychoziProhlidkaItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "První lékařská prohlídka",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vychoziProhlidkaItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Initial examination",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vychoziProhlidkaItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "First medical examination",
                    },
                    // PERIODICKA Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = periodickaProhlidkaItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Periodická prohlídka",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = periodickaProhlidkaItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Opakovaná lékařská prohlídka",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = periodickaProhlidkaItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Periodic examination",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = periodickaProhlidkaItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Repeated medical examination",
                    },
                }
            );

            // 3. Type of PosudekRo (DRUH-POSUDKU)
            var druhPosudkuCiselnik = new Ciselnik
            {
                Id = Guid.NewGuid(),
                Kod = "DRUH-POSUDKU",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(druhPosudkuCiselnik);

            var ridicskyPosudekItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = druhPosudkuCiselnik.Id,
                Kod = "RIDICKY",
                Verze = "1",
                CiselnikKod = druhPosudkuCiselnik.Kod,
                CiselnikVerze = druhPosudkuCiselnik.Verze,
            };
            codebookItems.Add(ridicskyPosudekItem);

            translations.AddRange(
                new[]
                {
                    // DRUH-POSUDKU Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhPosudkuCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Druh posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhPosudkuCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Typ lékařského posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhPosudkuCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Type of certificate",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = druhPosudkuCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Type of medical certificate",
                    },
                    // RIDICKY Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = ridicskyPosudekItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Řidičský posudek",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = ridicskyPosudekItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Posudek pro řidiče motorových vozidel",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = ridicskyPosudekItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Driver certificate",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = ridicskyPosudekItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Certificate for motor vehicle drivers",
                    },
                }
            );

            // 4. Result (VYSLEDEK)
            var vysledekCiselnik = new Ciselnik
            {
                Id = Guid.NewGuid(),
                Kod = "VYSLEDEK",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(vysledekCiselnik);

            var zpusobilyItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = vysledekCiselnik.Id,
                Kod = "ZPUSOBILY",
                Verze = "1",
                CiselnikKod = vysledekCiselnik.Kod,
                CiselnikVerze = vysledekCiselnik.Verze,
            };
            codebookItems.Add(zpusobilyItem);

            var nezpusobilyItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = vysledekCiselnik.Id,
                Kod = "NEZPUSOBILY",
                Verze = "1",
                CiselnikKod = vysledekCiselnik.Kod,
                CiselnikVerze = vysledekCiselnik.Verze,
            };
            codebookItems.Add(nezpusobilyItem);

            translations.AddRange(
                new[]
                {
                    // VYSLEDEK Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = vysledekCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Výsledek",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = vysledekCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Výsledek lékařského posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = vysledekCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Result",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = vysledekCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Result of medical certificate",
                    },
                    // ZPUSOBILY Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zpusobilyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Způsobilý",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zpusobilyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Pacient je způsobilý k řízení",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zpusobilyItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Fit",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zpusobilyItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Patient is fit to drive",
                    },
                    // NEZPUSOBILY Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = nezpusobilyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Nezpůsobilý",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = nezpusobilyItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Pacient není způsobilý k řízení",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = nezpusobilyItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Unfit",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = nezpusobilyItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Patient is unfit to drive",
                    },
                }
            );

            // 5. Driver Applicant Group (SKUPINA-ZADATELE-RIDIC)
            var skupinaZadateleCiselnik = new Ciselnik
            {
                Id = Guid.NewGuid(),
                Kod = "SKUPINA-ZADATELE-RIDIC",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(skupinaZadateleCiselnik);

            var skupinaAItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = skupinaZadateleCiselnik.Id,
                Kod = "A",
                Verze = "1",
                CiselnikKod = skupinaZadateleCiselnik.Kod,
                CiselnikVerze = skupinaZadateleCiselnik.Verze,
            };
            codebookItems.Add(skupinaAItem);

            var skupinaBItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = skupinaZadateleCiselnik.Id,
                Kod = "B",
                Verze = "1",
                CiselnikKod = skupinaZadateleCiselnik.Kod,
                CiselnikVerze = skupinaZadateleCiselnik.Verze,
            };
            codebookItems.Add(skupinaBItem);

            translations.AddRange(
                new[]
                {
                    // SKUPINA-ZADATELE-RIDIC Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = skupinaZadateleCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Skupina žadatele řidič",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = skupinaZadateleCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Skupina řidičského oprávnění",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = skupinaZadateleCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Driver applicant group",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = skupinaZadateleCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Driver license group",
                    },
                    // A Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaAItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Skupina A",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaAItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Řidičská skupina A (motocykly)",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaAItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Group A",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaAItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Driver group A (motorcycles)",
                    },
                    // B Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaBItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Skupina B",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaBItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Řidičská skupina B (automobily)",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaBItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Group B",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = skupinaBItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Driver group B (cars)",
                    },
                }
            );

            // 6. Medical Specialty (ODBNORNOST)
            var odbornostCiselnik = new Ciselnik
            {
                Id = Guid.NewGuid(),
                Kod = "ODBNORNOST",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(odbornostCiselnik);

            var interniLekarItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = odbornostCiselnik.Id,
                Kod = "INTERNI",
                Verze = "1",
                CiselnikKod = odbornostCiselnik.Kod,
                CiselnikVerze = odbornostCiselnik.Verze,
            };
            codebookItems.Add(interniLekarItem);

            var okulistaItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = odbornostCiselnik.Id,
                Kod = "OKULISTA",
                Verze = "1",
                CiselnikKod = odbornostCiselnik.Kod,
                CiselnikVerze = odbornostCiselnik.Verze,
            };
            codebookItems.Add(okulistaItem);

            translations.AddRange(
                new[]
                {
                    // ODBNORNOST Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = odbornostCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Odbornost",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = odbornostCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Lékařská odbornost",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = odbornostCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Specialty",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = odbornostCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Medical specialty",
                    },
                    // INTERNI Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = interniLekarItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Interní lékař",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = interniLekarItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Lékař interního lékařství",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = interniLekarItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Internal medicine",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = interniLekarItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Internal medicine physician",
                    },
                    // OKULISTA Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = okulistaItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Oční lékař",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = okulistaItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Oční lékař (oftalmolog)",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = okulistaItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Ophthalmologist",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = okulistaItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Eye physician (ophthalmologist)",
                    },
                }
            );

            // 7. Type of Action (TYP-AKCE)
            var typAkceCiselnik = new Ciselnik
            {
                Id = Guid.NewGuid(),
                Kod = "TYP-AKCE",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(typAkceCiselnik);

            var vydaniItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = typAkceCiselnik.Id,
                Kod = "VYDANI",
                Verze = "1",
                CiselnikKod = typAkceCiselnik.Kod,
                CiselnikVerze = typAkceCiselnik.Verze,
            };
            codebookItems.Add(vydaniItem);

            translations.AddRange(
                new[]
                {
                    // TYP-AKCE Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typAkceCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Typ akce",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typAkceCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Typ akce s posudkem",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typAkceCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Type of action",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typAkceCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Type of action with certificate",
                    },
                    // VYDANI Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vydaniItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Vydání",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vydaniItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Vydání nového posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vydaniItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Issuance",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vydaniItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Issuance of new certificate",
                    },
                }
            );

            // 8. Operation Type (TYP-OPERACE)
            var typOperaceCiselnik = new Ciselnik
            {
                Id = Guid.NewGuid(),
                Kod = "TYP-OPERACE",
                Verze = "1",
                PlatnostOd = now.AddYears(-1),
                Termx = false,
            };
            codebooks.Add(typOperaceCiselnik);

            var vytvoreniItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = typOperaceCiselnik.Id,
                Kod = "VYTVORENI",
                Verze = "1",
                CiselnikKod = typOperaceCiselnik.Kod,
                CiselnikVerze = typOperaceCiselnik.Verze,
            };
            codebookItems.Add(vytvoreniItem);

            var zneplatneniItem = new CiselnikPolozka
            {
                Id = Guid.NewGuid(),
                CiselnikId = typOperaceCiselnik.Id,
                Kod = "ZNEPLATNENI",
                Verze = "1",
                CiselnikKod = typOperaceCiselnik.Kod,
                CiselnikVerze = typOperaceCiselnik.Verze,
            };
            codebookItems.Add(zneplatneniItem);

            translations.AddRange(
                new[]
                {
                    // TYP-OPERACE Ciselnik
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typOperaceCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Typ operace",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typOperaceCiselnik.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Typ operace v historii",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typOperaceCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Operation type",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "Ciselnik",
                        EntityId = typOperaceCiselnik.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Type of operation in history",
                    },
                    // VYTVORENI Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vytvoreniItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Vytvoření",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vytvoreniItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Vytvoření posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vytvoreniItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Creation",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = vytvoreniItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Certificate creation",
                    },
                    // ZNEPLATNENI Item
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatneniItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Nazev",
                        Value = "Zneplatnění",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatneniItem.Id,
                        Language = "cs-CZ",
                        PropertyName = "Popis",
                        Value = "Zneplatnění posudku",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatneniItem.Id,
                        Language = "en-US",
                        PropertyName = "Nazev",
                        Value = "Invalidation",
                    },
                    new Translation
                    {
                        Id = Guid.NewGuid(),
                        EntityType = "CiselnikPolozka",
                        EntityId = zneplatneniItem.Id,
                        Language = "en-US",
                        PropertyName = "Popis",
                        Value = "Certificate invalidation",
                    },
                }
            );

            foreach (var translation in translations)
            {
                if (translation.EntityType == "Ciselnik")
                {
                    translation.CiselnikId = translation.EntityId;
                }
                else if (translation.EntityType == "CiselnikPolozka")
                {
                    translation.CiselnikPolozkaId = translation.EntityId;
                }
            }

            // Seed Ciselniks, CiselnikPolozkas, and Translations
            modelBuilder.Entity<Ciselnik>().HasData(codebooks);
            modelBuilder.Entity<CiselnikPolozka>().HasData(codebookItems);
            modelBuilder.Entity<Translation>().HasData(translations);

            // Seed Patients
            var patients = new List<Pacient>
            {
                new Pacient
                {
                    Rid = Guid.NewGuid(),
                    Jmeno = "Jan",
                    Prijmeni = "Novák",
                    DatumNarozeni = new DateTime(1985, 5, 20),
                    Adresa = "Praha 1, Václavské náměstí 1",
                    Email = "jan.novak@example.com",
                    Doklad = "AA123456",
                    Pohlavi = "M",
                },
                new Pacient
                {
                    Rid = Guid.NewGuid(),
                    Jmeno = "Marie",
                    Prijmeni = "Svobodová",
                    DatumNarozeni = new DateTime(1990, 3, 15),
                    Adresa = "Brno, Náměstí Svobody 10",
                    Email = "marie.svobodova@example.com",
                    Doklad = "BB654321",
                    Pohlavi = "F",
                },
                new Pacient
                {
                    Rid = Guid.NewGuid(),
                    Jmeno = "Petr",
                    Prijmeni = "Dvořák",
                    DatumNarozeni = new DateTime(1978, 11, 8),
                    Adresa = "Ostrava, Masarykovo náměstí 5",
                    Email = "petr.dvorak@example.com",
                    Doklad = "CC987654",
                    Pohlavi = "M",
                },
            };

            // Seed Healthcare Providers
            var providers = new List<PoskytovatelZdravotnickychSluzeb>
            {
                new PoskytovatelZdravotnickychSluzeb
                {
                    Id = Guid.NewGuid(),
                    Ico = "12345678",
                    Nazev = "Zdravotní zařízení s.r.o.",
                    Adresa = "Praha 2, Karlovo náměstí 10",
                },
                new PoskytovatelZdravotnickychSluzeb
                {
                    Id = Guid.NewGuid(),
                    Ico = "87654321",
                    Nazev = "Lékařská klinika Brno a.s.",
                    Adresa = "Brno, Hlavní třída 25",
                },
                new PoskytovatelZdravotnickychSluzeb
                {
                    Id = Guid.NewGuid(),
                    Ico = "11223344",
                    Nazev = "Oční ambulance Ostrava",
                    Adresa = "Ostrava, Polská 15",
                },
            };

            // Seed Medical Workers
            var doctors = new List<ZdravotnickyPracovnik>
            {
                new ZdravotnickyPracovnik
                {
                    KrzpId = Guid.NewGuid(),
                    Jmeno = "Petr",
                    Prijmeni = "Dvořák",
                    OdbornostId = interniLekarItem.Id,
                    PoskytovatelId = providers[0].Id,
                },
                new ZdravotnickyPracovnik
                {
                    KrzpId = Guid.NewGuid(),
                    Jmeno = "Anna",
                    Prijmeni = "Novotná",
                    OdbornostId = okulistaItem.Id,
                    PoskytovatelId = providers[1].Id,
                },
                new ZdravotnickyPracovnik
                {
                    KrzpId = Guid.NewGuid(),
                    Jmeno = "Michal",
                    Prijmeni = "Procházka",
                    OdbornostId = interniLekarItem.Id,
                    PoskytovatelId = providers[2].Id,
                },
            };

            // Seed sample certificates
            var certificates = new List<PosudekRo>
            {
                new PosudekRo
                {
                    Id = Guid.NewGuid(),
                    Rid = patients[0].Rid,
                    KrzpId = doctors[0].KrzpId,
                    StavPosudkuId = platnyItem.Id,
                    DruhProhlidkyId = vychoziProhlidkaItem.Id,
                    DruhPosudkuId = ridicskyPosudekItem.Id,
                    TypAkceId = vydaniItem.Id,
                    VysledekId = zpusobilyItem.Id,
                    SkupinaZadateleRidicId = skupinaBItem.Id,
                    DatumVystaveni = now.Date,
                    PlatnostDo = now.Date.AddYears(1),
                    DatumVytvoreni = now,
                },
                new PosudekRo
                {
                    Id = Guid.NewGuid(),
                    Rid = patients[1].Rid,
                    KrzpId = doctors[1].KrzpId,
                    StavPosudkuId = platnyItem.Id,
                    DruhProhlidkyId = periodickaProhlidkaItem.Id,
                    DruhPosudkuId = ridicskyPosudekItem.Id,
                    TypAkceId = vydaniItem.Id,
                    VysledekId = zpusobilyItem.Id,
                    SkupinaZadateleRidicId = skupinaAItem.Id,
                    DatumVystaveni = now.Date.AddDays(-30),
                    PlatnostDo = now.Date.AddMonths(6),
                    DatumVytvoreni = now.AddDays(-30),
                },
            };

            // Seed certificate fitness assessments
            var zpusobilosti = new List<PosudekRoZpusobilost>
            {
                new PosudekRoZpusobilost
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificates[0].Id,
                    SkupinaZadateleRidicId = skupinaBItem.Id,
                    VysledekId = zpusobilyItem.Id,
                },
                new PosudekRoZpusobilost
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificates[1].Id,
                    SkupinaZadateleRidicId = skupinaAItem.Id,
                    VysledekId = zpusobilyItem.Id,
                },
            };

            // Seed certificate history
            var histories = new List<PosudekRoHistory>
            {
                new PosudekRoHistory
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificates[0].Id,
                    TypOperaceId = vytvoreniItem.Id,
                    DatumOperace = now,
                    KrzpId = doctors[0].KrzpId,
                },
                new PosudekRoHistory
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificates[1].Id,
                    TypOperaceId = vytvoreniItem.Id,
                    DatumOperace = now.AddDays(-30),
                    KrzpId = doctors[1].KrzpId,
                },
            };

            modelBuilder.Entity<Pacient>().HasData(patients);
            modelBuilder.Entity<PoskytovatelZdravotnickychSluzeb>().HasData(providers);
            modelBuilder.Entity<ZdravotnickyPracovnik>().HasData(doctors);
            modelBuilder.Entity<PosudekRo>().HasData(certificates);
            modelBuilder.Entity<PosudekRoZpusobilost>().HasData(zpusobilosti);
            modelBuilder.Entity<PosudekRoHistory>().HasData(histories);
        }
    }
}

using ElektronickePosudky.Domain.Entities;
using ElektronickePosudky.Infrastructure.Utils;
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

            /*---------------------------------------------------
            - Load seeding data from specific json files (saved from https://terminologie.ezdravi.gov.cz/resources/value-sets)
            ---------------------------------------------------
            elp-ro-akce.json
            elp-ro-druh-posudku.json
            elp-ro-druh-prohlidky.json
            elp-ro-harmonizovane-kody.json
            elp-ro-narodni-kody.json
            elp-ro-seznam-skupin.json
            elp-ro-stav-posudku.json
            elp-ro-vysledek-posudku.json
            elp-ro-zadatel-skupina.json
            ---------------------------------------------------*/

            var akceCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-akce.json",
                CiselnikType.Akce
            );
            codebooks.Add(akceCodelistResult.codebook);
            codebookItems.AddRange(akceCodelistResult.items);
            translations.AddRange(akceCodelistResult.translations);

            var posudkuCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-druh-posudku.json",
                CiselnikType.DruhPosudku
            );
            codebooks.Add(posudkuCodelistResult.codebook);
            codebookItems.AddRange(posudkuCodelistResult.items);
            translations.AddRange(posudkuCodelistResult.translations);

            var prohlidkyCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-druh-prohlidky.json",
                CiselnikType.DruhProhlidky
            );
            codebooks.Add(prohlidkyCodelistResult.codebook);
            codebookItems.AddRange(prohlidkyCodelistResult.items);
            translations.AddRange(prohlidkyCodelistResult.translations);

            var harmonizovaneCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-harmonizovane-kody.json",
                CiselnikType.HarmonizovaneKody
            );
            codebooks.Add(harmonizovaneCodelistResult.codebook);
            codebookItems.AddRange(harmonizovaneCodelistResult.items);
            translations.AddRange(harmonizovaneCodelistResult.translations);

            var narodniCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-narodni-kody.json",
                CiselnikType.NarodniKody
            );
            codebooks.Add(narodniCodelistResult.codebook);
            codebookItems.AddRange(narodniCodelistResult.items);
            translations.AddRange(narodniCodelistResult.translations);

            var skupinCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-seznam-skupin.json",
                CiselnikType.SeznamSkupin
            );
            codebooks.Add(skupinCodelistResult.codebook);
            codebookItems.AddRange(skupinCodelistResult.items);
            translations.AddRange(skupinCodelistResult.translations);

            var stavCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-stav-posudku.json",
                CiselnikType.StavPosudku
            );
            codebooks.Add(stavCodelistResult.codebook);
            codebookItems.AddRange(stavCodelistResult.items);
            translations.AddRange(stavCodelistResult.translations);

            var vysledekCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-vysledek-posudku.json",
                CiselnikType.Vysledek
            );
            codebooks.Add(vysledekCodelistResult.codebook);
            codebookItems.AddRange(vysledekCodelistResult.items);
            translations.AddRange(vysledekCodelistResult.translations);

            var zadatelCodelistResult = CodebookUtils.ParseJsonCodebook(
                "elp-ro-zadatel-skupina.json",
                CiselnikType.ZadatelSkupina
            );
            codebooks.Add(zadatelCodelistResult.codebook);
            codebookItems.AddRange(zadatelCodelistResult.items);
            translations.AddRange(zadatelCodelistResult.translations);

            var odbnornostCodelistResult = CodebookUtils.GenerateOdbnornost();
            codebooks.Add(odbnornostCodelistResult.codebook);
            codebookItems.AddRange(odbnornostCodelistResult.items);
            translations.AddRange(odbnornostCodelistResult.translations);

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
                    Rid = GuidUtils.Generate(GuidUtils.PacientPrefix, 1),
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
                    Rid = GuidUtils.Generate(GuidUtils.PacientPrefix, 2),
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
                    Rid = GuidUtils.Generate(GuidUtils.PacientPrefix, 3),
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
                    Id = GuidUtils.Generate(GuidUtils.PoskytovatelZdravotnickychSluzebPrefix, 1),
                    Ico = "12345678",
                    Nazev = "Zdravotní zařízení s.r.o.",
                    Adresa = "Praha 2, Karlovo náměstí 10",
                },
                new PoskytovatelZdravotnickychSluzeb
                {
                    Id = GuidUtils.Generate(GuidUtils.PoskytovatelZdravotnickychSluzebPrefix, 2),
                    Ico = "87654321",
                    Nazev = "Lékařská klinika Brno a.s.",
                    Adresa = "Brno, Hlavní třída 25",
                },
                new PoskytovatelZdravotnickychSluzeb
                {
                    Id = GuidUtils.Generate(GuidUtils.PoskytovatelZdravotnickychSluzebPrefix, 3),
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
                    KrzpId = GuidUtils.Generate(GuidUtils.ZdravotnickyPracovnikPrefix, 1),
                    Jmeno = "Petr",
                    Prijmeni = "Dvořák",
                    OdbornostId = odbnornostCodelistResult.items[0].Id,
                    PoskytovatelId = providers[0].Id,
                },
                new ZdravotnickyPracovnik
                {
                    KrzpId = GuidUtils.Generate(GuidUtils.ZdravotnickyPracovnikPrefix, 2),
                    Jmeno = "Anna",
                    Prijmeni = "Novotná",
                    OdbornostId = odbnornostCodelistResult.items[1].Id,
                    PoskytovatelId = providers[1].Id,
                },
                new ZdravotnickyPracovnik
                {
                    KrzpId = GuidUtils.Generate(GuidUtils.ZdravotnickyPracovnikPrefix, 3),
                    Jmeno = "Michal",
                    Prijmeni = "Procházka",
                    OdbornostId = odbnornostCodelistResult.items[0].Id,
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
                    StavPosudkuId = codebookItems.FindByKod("stav_posudku_1")?.Id,
                    DruhProhlidkyId = codebookItems.FindByKod("druh_prohlidky_ro_1")?.Id,
                    DruhPosudkuId = codebookItems.FindByKod("druh_posudku_ro_1")?.Id,
                    TypAkceId = codebookItems.FindByKod("akce_ro_1")?.Id,
                    VysledekId = codebookItems.FindByKod("vysledek_posudku_ro_1")?.Id,
                    SkupinaZadateleRidicId = codebookItems.FindByKod("skupina_ro_2")?.Id,
                    DatumVystaveni = now.Date,
                    PlatnostDo = now.Date.AddYears(1),
                    DatumVytvoreni = now,
                },
                new PosudekRo
                {
                    Id = Guid.NewGuid(),
                    Rid = patients[1].Rid,
                    KrzpId = doctors[1].KrzpId,
                    StavPosudkuId = codebookItems.FindByKod("stav_posudku_1")?.Id,
                    DruhProhlidkyId = codebookItems.FindByKod("druh_prohlidky_ro_2")?.Id,
                    DruhPosudkuId = codebookItems.FindByKod("druh_posudku_ro_1")?.Id,
                    TypAkceId = codebookItems.FindByKod("akce_ro_1")?.Id,
                    VysledekId = codebookItems.FindByKod("vysledek_posudku_ro_1")?.Id,
                    SkupinaZadateleRidicId = codebookItems.FindByKod("skupina_ro_1")?.Id,
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
                    SkupinaZadateleRidicId = codebookItems.FindByKod("skupina_ro_2")!.Id,
                    VysledekId = codebookItems.FindByKod("vysledek_posudku_ro_1")!.Id,
                },
                new PosudekRoZpusobilost
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificates[1].Id,
                    SkupinaZadateleRidicId = codebookItems.FindByKod("skupina_ro_1")!.Id,
                    VysledekId = codebookItems.FindByKod("vysledek_posudku_ro_1")!.Id,
                },
            };

            // Seed certificate history
            var histories = new List<PosudekRoHistory>
            {
                new PosudekRoHistory
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificates[0].Id,
                    TypOperaceId = codebookItems.FindByKod("akce_ro_1")!.Id,
                    DatumOperace = now,
                    KrzpId = doctors[0].KrzpId,
                },
                new PosudekRoHistory
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificates[1].Id,
                    TypOperaceId = codebookItems.FindByKod("akce_ro_1")!.Id,
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

        private static Ciselnik? FindByKod(this IEnumerable<Ciselnik> items, string kod) =>
            items.FirstOrDefault(x => x.Kod.Equals(kod));

        private static CiselnikPolozka? FindByKod(
            this IEnumerable<CiselnikPolozka> items,
            string kod
        ) => items.FirstOrDefault(x => x.Kod.Equals(kod));
    }
}

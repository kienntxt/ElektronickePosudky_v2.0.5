using System.Linq;
using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Handlers;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class CreatePosudekHandlerTests
    {
        [Fact]
        public async Task Handle_CreatesBasicCertificateWithRequiredFields()
        {
            await using var context = TestHelpers.CreateContext();

            var patient = await context.Pacienti.FirstAsync();
            var doctor = await context.ZdravotnickyPracovnici.FirstAsync();
            var platnyItem = await context.CiselnikPolozky.FirstAsync(x =>
                x.Kod == "stav_posudku_1"
            );

            var handler = new CreatePosudekHandler(context, TestHelpers.CreateMapper());
            var command = new CreatePosudekCommand
            {
                Posudek = new PosudekRoCreateDto
                {
                    Rid = patient.Rid,
                    KrzpId = doctor.KrzpId,
                    DatumVystaveni = System.DateTime.UtcNow.Date,
                    PlatnostDo = System.DateTime.UtcNow.Date.AddYears(1),
                    TypAkce = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "akce_ro_1",
                        Verze = "1.0.0",
                    },
                    StavPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "stav_posudku_1",
                        Verze = "1.0.0",
                    },
                    DruhProhlidky = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_prohlidky_ro_1",
                        Verze = "1.0.0",
                    },
                    DruhPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_posudku_ro_1",
                        Verze = "1.0.0",
                    },
                    Zpusobilosti = System.Array.Empty<PosudekRoZpusobilostCreateDto>(),
                },
            };

            var result = await handler.Handle(command, System.Threading.CancellationToken.None);

            result.Should().NotBeNull();
            result.Hlavicka.Should().NotBeNull();

            var savedCertificate = await context.PosudekRos.FirstOrDefaultAsync(x =>
                x.Rid == patient.Rid && x.KrzpId == doctor.KrzpId
            );
            savedCertificate.Should().NotBeNull();
            savedCertificate!.Rid.Should().Be(patient.Rid);
            savedCertificate.KrzpId.Should().Be(doctor.KrzpId);
            savedCertificate.StavPosudkuId.Should().Be(platnyItem.Id);
        }

        [Fact]
        public async Task Handle_CreatesHistoryEntryForNewCertificate()
        {
            await using var context = TestHelpers.CreateContext();

            var patient = await context.Pacienti.FirstAsync();
            var doctor = await context.ZdravotnickyPracovnici.FirstAsync();

            var handler = new CreatePosudekHandler(context, TestHelpers.CreateMapper());
            var command = new CreatePosudekCommand
            {
                Posudek = new PosudekRoCreateDto
                {
                    Rid = patient.Rid,
                    KrzpId = doctor.KrzpId,
                    DatumVystaveni = System.DateTime.UtcNow.Date,
                    TypAkce = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "akce_ro_1",
                        Verze = "1.0.0",
                    },
                    StavPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "stav_posudku_1",
                        Verze = "1.0.0",
                    },
                    DruhProhlidky = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_prohlidky_ro_1",
                        Verze = "1.0.0",
                    },
                    DruhPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_posudku_ro_1",
                        Verze = "1.0.0",
                    },
                    Zpusobilosti = System.Array.Empty<PosudekRoZpusobilostCreateDto>(),
                },
            };

            var result = await handler.Handle(command, System.Threading.CancellationToken.None);

            var certificate = await context.PosudekRos.FirstOrDefaultAsync(x =>
                x.Rid == patient.Rid && x.KrzpId == doctor.KrzpId
            );
            var history = await context.PosudekRoHistories.FirstOrDefaultAsync(x =>
                x.PosudekRoId == certificate!.Id
            );
            history.Should().NotBeNull();
            history!.KrzpId.Should().Be(doctor.KrzpId);
            history
                .DatumOperace.Should()
                .BeCloseTo(System.DateTime.UtcNow, System.TimeSpan.FromSeconds(5));
        }

        [Fact]
        public async Task Handle_ResolvesCodebookItemsCorrectly()
        {
            await using var context = TestHelpers.CreateContext();

            var patient = await context.Pacienti.FirstAsync();
            var doctor = await context.ZdravotnickyPracovnici.FirstAsync();
            var platnyItem = await context.CiselnikPolozky.FirstAsync(x =>
                x.Kod == "stav_posudku_1"
            );
            var vychoziProhlidka = await context.CiselnikPolozky.FirstAsync(x =>
                x.Kod == "druh_prohlidky_ro_1"
            );

            var handler = new CreatePosudekHandler(context, TestHelpers.CreateMapper());
            var command = new CreatePosudekCommand
            {
                Posudek = new PosudekRoCreateDto
                {
                    Rid = patient.Rid,
                    KrzpId = doctor.KrzpId,
                    DatumVystaveni = System.DateTime.UtcNow.Date,
                    TypAkce = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "akce_ro_1",
                        Verze = "1.0.0",
                    },
                    StavPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "stav_posudku_1",
                        Verze = "1.0.0",
                    },
                    DruhProhlidky = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_prohlidky_ro_1",
                        Verze = "1.0.0",
                    },
                    DruhPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_posudku_ro_1",
                        Verze = "1.0.0",
                    },
                    Zpusobilosti = System.Array.Empty<PosudekRoZpusobilostCreateDto>(),
                },
            };

            var result = await handler.Handle(command, System.Threading.CancellationToken.None);

            result.Hlavicka!.StavPosudku.Should().NotBeNull();
            result.Hlavicka!.StavPosudku!.PolozkaKod.Should().Be("stav_posudku_1");
            result.Hlavicka!.DruhProhlidky.Should().NotBeNull();
            result.Hlavicka!.DruhProhlidky!.PolozkaKod.Should().Be("druh_prohlidky_ro_1");
            result.Hlavicka!.DruhPosudku.Should().NotBeNull();
            result.Hlavicka!.DruhPosudku!.PolozkaKod.Should().Be("druh_posudku_ro_1");

            var certificate = await context.PosudekRos.FirstOrDefaultAsync(x =>
                x.Rid == patient.Rid && x.KrzpId == doctor.KrzpId
            );
            certificate!.StavPosudkuId.Should().Be(platnyItem.Id);
            certificate.DruhProhlidkyId.Should().Be(vychoziProhlidka.Id);
        }

        [Fact]
        public async Task Handle_AllowsNullZpusobilosti()
        {
            await using var context = TestHelpers.CreateContext();

            var patient = await context.Pacienti.FirstAsync();
            var doctor = await context.ZdravotnickyPracovnici.FirstAsync();

            var handler = new CreatePosudekHandler(context, TestHelpers.CreateMapper());
            var command = new CreatePosudekCommand
            {
                Posudek = new PosudekRoCreateDto
                {
                    Rid = patient.Rid,
                    KrzpId = doctor.KrzpId,
                    DatumVystaveni = System.DateTime.UtcNow.Date,
                    TypAkce = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "akce_ro_1",
                        Verze = "1.0.0",
                    },
                    StavPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "stav_posudku_1",
                        Verze = "1.0.0",
                    },
                    DruhProhlidky = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_prohlidky_ro_1",
                        Verze = "1.0.0",
                    },
                    DruhPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_posudku_ro_1",
                        Verze = "1.0.0",
                    },
                    Zpusobilosti = null,
                },
            };

            var result = await handler.Handle(command, System.Threading.CancellationToken.None);

            result.Should().NotBeNull();
            result.Hlavicka.Should().NotBeNull();
        }

        [Fact]
        public async Task Handle_CreatesSingleZpusobilost()
        {
            await using var context = TestHelpers.CreateContext();

            var patient = await context.Pacienti.FirstAsync();
            var doctor = await context.ZdravotnickyPracovnici.FirstAsync();

            var handler = new CreatePosudekHandler(context, TestHelpers.CreateMapper());
            var command = new CreatePosudekCommand
            {
                Posudek = new PosudekRoCreateDto
                {
                    Rid = patient.Rid,
                    KrzpId = doctor.KrzpId,
                    DatumVystaveni = System.DateTime.UtcNow.Date,
                    TypAkce = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "akce_ro_1",
                        Verze = "1.0.0",
                    },
                    StavPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "stav_posudku_1",
                        Verze = "1.0.0",
                    },
                    DruhProhlidky = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_prohlidky_ro_1",
                        Verze = "1.0.0",
                    },
                    DruhPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "druh_posudku_ro_1",
                        Verze = "1.0.0",
                    },
                    Zpusobilosti =
                    [
                        new PosudekRoZpusobilostCreateDto
                        {
                            SkupinaZadateleRidic = new PosudekRoCiselnikPolozkaCreateDto
                            {
                                Kod = "A1",
                                Verze = "1.0.0",
                            },
                            Vysledek = new PosudekRoCiselnikPolozkaCreateDto
                            {
                                Kod = "vysledek_posudku_ro_1",
                                Verze = "1.0.0",
                            },
                            SkupinyRidicskehoOpravneni =
                                System.Array.Empty<PosudekRoSkupinaCreateDto>(),
                        },
                    ],
                },
            };

            var result = await handler.Handle(command, System.Threading.CancellationToken.None);

            // Verify the result has zpusobilosti
            result.Zpusobilosti.Should().NotBeNull();
            result.Zpusobilosti!.Count.Should().BeGreaterThanOrEqualTo(1);

            // Verify zpusobilost was saved to database
            var certificate = await context.PosudekRos.FirstOrDefaultAsync(x =>
                x.Rid == patient.Rid && x.KrzpId == doctor.KrzpId
            );
            var savedZpusobilosti = await context
                .PosudekRoZpusobilosti.Where(x => x.PosudekRoId == certificate!.Id)
                .ToListAsync();
            savedZpusobilosti.Count.Should().BeGreaterThanOrEqualTo(1);
        }
    }
}

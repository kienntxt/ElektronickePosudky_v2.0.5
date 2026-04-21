using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.Handlers;
using ElektronickePosudky.Domain.Entities;
using ElektronickePosudky.Infrastructure.Persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class InvalidatePosudekHandlerTests
    {
        [Fact]
        public async Task Handle_ChangesStatusToInvalidatedAndAddsHistory()
        {
            await using var context = TestHelpers.CreateContext();

            var patient = await context.Pacienti.FirstAsync();
            var doctor = await context.ZdravotnickyPracovnici.FirstAsync();
            var platnyItem = await context.CiselnikPolozky.FirstAsync(x =>
                x.Kod == "stav_posudku_1"
            );
            var zneplatnenyItem = await context.CiselnikPolozky.FirstAsync(x =>
                x.Kod == "stav_posudku_3"
            );
            var typAkce = await context.CiselnikPolozky.FirstAsync(x =>
                x.CiselnikKod == "akce-ro" //invalidate
            );
            var druhProhlidky = await context.CiselnikPolozky.FirstAsync(x =>
                x.CiselnikKod == "druh-prohlidky-ro"
            );
            var druhPosudku = await context.CiselnikPolozky.FirstAsync(x =>
                x.CiselnikKod == "druh-posudku-ro"
            );
            var vysledek = await context.CiselnikPolozky.FirstAsync(x =>
                x.CiselnikKod == "vysledek-posudku-ro"
            );
            var skupinaZadatele = await context.CiselnikPolozky.FirstAsync(x =>
                x.CiselnikKod == "skupina-zadatel-ridic-ro"
            );

            var certificate = new PosudekRo
            {
                Id = System.Guid.NewGuid(),
                Rid = patient.Rid,
                KrzpId = doctor.KrzpId,
                StavPosudkuId = platnyItem.Id,
                DruhProhlidkyId = druhProhlidky.Id,
                DruhPosudkuId = druhPosudku.Id,
                TypAkceId = typAkce.Id,
                VysledekId = vysledek.Id,
                SkupinaZadateleRidicId = skupinaZadatele.Id,
                DatumVystaveni = System.DateTime.UtcNow,
                DatumVytvoreni = System.DateTime.UtcNow,
                RowVersion = new byte[] { 1, 2, 3, 4 },
            };

            certificate.Zpusobilosti.Add(
                new PosudekRoZpusobilost
                {
                    Id = System.Guid.NewGuid(),
                    PosudekRoId = certificate.Id,
                    SkupinaZadateleRidicId = skupinaZadatele.Id,
                    VysledekId = vysledek.Id,
                }
            );

            context.PosudekRos.Add(certificate);
            await context.SaveChangesAsync();

            var handler = new InvalidatePosudekHandler(context, TestHelpers.CreateMapper());
            var result = await handler.Handle(
                new InvalidatePosudekCommand
                {
                    Id = certificate.Id,
                    IfMatch = System.Convert.ToBase64String(certificate.RowVersion!),
                },
                System.Threading.CancellationToken.None
            );

            result.Should().NotBeNull();
            result.Id.Should().Be(certificate.Id);
            result.StavPosudku.Should().NotBeNull();
            result.StavPosudku!.PolozkaKod.Should().Be("stav_posudku_3");
            result.VerzeZaznamu.Should().NotBeNull();

            var historyExists = await context.PosudekRoHistories.AnyAsync(x =>
                x.PosudekRoId == certificate.Id
            );
            historyExists.Should().BeTrue();
        }

        [Fact]
        public async Task Handle_ThrowsKeyNotFoundExceptionWhenCertificateMissing()
        {
            await using var context = TestHelpers.CreateContext();
            var handler = new InvalidatePosudekHandler(context, TestHelpers.CreateMapper());

            await handler
                .Invoking(h =>
                    h.Handle(
                        new InvalidatePosudekCommand
                        {
                            Id = System.Guid.NewGuid(),
                            IfMatch = System.Convert.ToBase64String(new byte[] { 1, 2, 3, 4 }),
                        },
                        System.Threading.CancellationToken.None
                    )
                )
                .Should()
                .ThrowAsync<KeyNotFoundException>();
        }
    }
}

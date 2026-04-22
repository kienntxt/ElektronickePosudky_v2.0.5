using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Validators;
using ElektronickePosudky.Infrastructure.Utils;
using FluentAssertions;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class CreatePosudekValidatorTests
    {
        [Fact]
        public void Validate_ReturnsValidResultForValidCommand()
        {
            using var context = TestHelpers.CreateContext();
            var validator = new CreatePosudekValidator(context);
            var command = new CreatePosudekCommand
            {
                Posudek = new PosudekRoCreateDto
                {
                    Rid = GuidUtils.Generate(GuidUtils.PacientPrefix, 1),
                    KrzpId = GuidUtils.Generate(GuidUtils.ZdravotnickyPracovnikPrefix, 1),
                    DatumVystaveni = System.DateTime.UtcNow,
                    TypAkce = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "akce_ro_1",
                        Verze = "1.0.0",
                    },
                    StavPosudku = new PosudekRoCiselnikPolozkaCreateDto
                    {
                        Kod = "stav_posudku_2",
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
                                Kod = "skupina_ro_1",
                                Verze = "1.0.0",
                            },
                            Vysledek = new PosudekRoCiselnikPolozkaCreateDto
                            {
                                Kod = "vysledek_posudku_ro_1",
                                Verze = "1.0.0",
                            },
                            SkupinyRidicskehoOpravneni =
                            [
                                new PosudekRoSkupinaCreateDto
                                {
                                    SkupinaRo = new PosudekRoCiselnikPolozkaCreateDto
                                    {
                                        Kod = "A",
                                        Verze = "1.0.0",
                                    },
                                },
                            ],
                        },
                    ],
                },
            };

            var result = validator.Validate(command);

            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void Validate_ReturnsInvalidResultWhenRequiredFieldsAreMissing()
        {
            using var context = TestHelpers.CreateContext();
            var validator = new CreatePosudekValidator(context);
            var command = new CreatePosudekCommand();

            var result = validator.Validate(command);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
        }
    }
}

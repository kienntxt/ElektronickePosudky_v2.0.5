using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Validators;
using FluentAssertions;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class CreatePosudekValidatorTests
    {
        [Fact]
        public void Validate_ReturnsValidResultForValidCommand()
        {
            var validator = new CreatePosudekValidator();
            var command = new CreatePosudekCommand
            {
                Posudek = new PosudekRoCreateDto
                {
                    Rid = System.Guid.NewGuid(),
                    KrzpId = System.Guid.NewGuid(),
                    DatumVystaveni = System.DateTime.UtcNow,
                    TypAkce = new PosudekRoCiselnikPolozkaCreateDto(),
                    StavPosudku = new PosudekRoCiselnikPolozkaCreateDto(),
                    DruhProhlidky = new PosudekRoCiselnikPolozkaCreateDto(),
                    DruhPosudku = new PosudekRoCiselnikPolozkaCreateDto(),
                    Zpusobilosti = new[]
                    {
                        new PosudekRoZpusobilostCreateDto
                        {
                            SkupinaZadateleRidic = new PosudekRoCiselnikPolozkaCreateDto(),
                            Vysledek = new PosudekRoCiselnikPolozkaCreateDto(),
                            SkupinyRidicskehoOpravneni = new[] { new PosudekRoSkupinaCreateDto() },
                        },
                    },
                },
            };

            var result = validator.Validate(command);

            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void Validate_ReturnsInvalidResultWhenRequiredFieldsAreMissing()
        {
            var validator = new CreatePosudekValidator();
            var command = new CreatePosudekCommand();

            var result = validator.Validate(command);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
        }
    }
}

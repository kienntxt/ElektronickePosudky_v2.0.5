using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Validators;
using FluentAssertions;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class OpravneniValidatorTests
    {
        [Fact]
        public void Validate_ReturnsValidResultForValidRequest()
        {
            var validator = new OpravneniValidator();
            var command = new CheckOpravneniCommand
            {
                Request = new PosudekRoOpravneniRequestDto
                {
                    Ico = "12345678",
                    KrzpId = System.Guid.NewGuid().ToString(),
                },
            };

            var result = validator.Validate(command);

            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void Validate_ReturnsInvalidResultWhenFieldsAreMissingOrInvalid()
        {
            var validator = new OpravneniValidator();
            var command = new CheckOpravneniCommand
            {
                Request = new PosudekRoOpravneniRequestDto
                {
                    Ico = string.Empty,
                    KrzpId = "not-a-guid",
                },
            };

            var result = validator.Validate(command);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(x => x.PropertyName == "Request.Ico");
            result.Errors.Should().Contain(x => x.PropertyName == "Request.KrzpId");
        }
    }
}

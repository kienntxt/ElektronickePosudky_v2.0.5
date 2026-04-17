using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.Validators;
using FluentAssertions;
using Xunit;

namespace ElektronickePosudky.Tests.Unit
{
    public class InvalidatePosudekValidatorTests
    {
        [Fact]
        public void Validate_ReturnsValidResultForValidCommand()
        {
            var validator = new InvalidatePosudekValidator();
            var command = new InvalidatePosudekCommand
            {
                Id = System.Guid.NewGuid(),
                IfMatch = System.Convert.ToBase64String(new byte[] { 1, 2, 3 }),
            };

            var result = validator.Validate(command);

            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void Validate_ReturnsInvalidResultWhenIdOrIfMatchMissing()
        {
            var validator = new InvalidatePosudekValidator();
            var command = new InvalidatePosudekCommand();

            var result = validator.Validate(command);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(x => x.PropertyName == "Id");
            result.Errors.Should().Contain(x => x.PropertyName == "IfMatch");
        }
    }
}

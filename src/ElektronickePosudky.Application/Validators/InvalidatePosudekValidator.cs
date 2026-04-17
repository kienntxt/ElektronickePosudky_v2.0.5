using ElektronickePosudky.Application.Commands;
using FluentValidation;

namespace ElektronickePosudky.Application.Validators
{
    public sealed class InvalidatePosudekValidator : AbstractValidator<InvalidatePosudekCommand>
    {
        public InvalidatePosudekValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.IfMatch).NotEmpty().WithMessage("If-Match header is required.");
        }
    }
}

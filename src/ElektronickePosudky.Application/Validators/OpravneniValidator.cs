using ElektronickePosudky.Application.Commands;
using FluentValidation;

namespace ElektronickePosudky.Application.Validators
{
    public sealed class OpravneniValidator : AbstractValidator<CheckOpravneniCommand>
    {
        public OpravneniValidator()
        {
            RuleFor(x => x.Request).NotNull();
            RuleFor(x => x.Request.Ico).NotEmpty();
            RuleFor(x => x.Request.KrzpId)
                .NotEmpty()
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Must be Guid");
        }
    }
}

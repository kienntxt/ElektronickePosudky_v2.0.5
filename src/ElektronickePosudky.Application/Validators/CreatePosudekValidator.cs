using ElektronickePosudky.Application.Commands;
using FluentValidation;

namespace ElektronickePosudky.Application.Validators
{
    public sealed class CreatePosudekValidator : AbstractValidator<CreatePosudekCommand>
    {
        public CreatePosudekValidator()
        {
            RuleFor(x => x.Posudek).NotNull();
            RuleFor(x => x.Posudek.Rid).NotEmpty();
            RuleFor(x => x.Posudek.KrzpId).NotEmpty();
            RuleFor(x => x.Posudek.DatumVystaveni).NotEmpty();
            RuleFor(x => x.Posudek.TypAkce).NotNull();
            RuleFor(x => x.Posudek.StavPosudku).NotNull();
            RuleFor(x => x.Posudek.DruhProhlidky).NotNull();
            RuleFor(x => x.Posudek.DruhPosudku).NotNull();
            RuleFor(x => x.Posudek.Zpusobilosti).NotNull().NotEmpty();
            RuleForEach(x => x.Posudek.Zpusobilosti)
                .ChildRules(z =>
                {
                    z.RuleFor(y => y.SkupinaZadateleRidic).NotNull();
                    z.RuleFor(y => y.SkupinyRidicskehoOpravneni).NotEmpty();
                    z.RuleFor(y => y.Vysledek).NotNull();
                });
        }
    }
}

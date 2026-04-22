using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Validators
{
    public sealed class CreatePosudekValidator : AbstractValidator<CreatePosudekCommand>
    {
        private IElektronickePosudkyContext _context;

        public CreatePosudekValidator(IElektronickePosudkyContext context)
        {
            _context = context;
            RuleFor(x => x.Posudek).NotNull();
            RuleFor(x => x.Posudek.Rid)
                .NotEmpty()
                .Must(x => _context.Pacienti.AsNoTracking().Any(e => e.Rid == x))
                .WithMessage(x => $"Not found {x.Posudek.Rid} in the database");
            RuleFor(x => x.Posudek.KrzpId)
                .NotEmpty()
                .Must(x => _context.ZdravotnickyPracovnici.AsNoTracking().Any(e => e.KrzpId == x))
                .WithMessage(x => $"Not found {x.Posudek.KrzpId} in the database");
            RuleFor(x => x.Posudek.DatumVystaveni).NotEmpty();
            RuleFor(x => x.Posudek.TypAkce)
                .NotNull()
                .SetValidator(new CiselnikPolozkaValidator(context));

            RuleFor(x => x.Posudek.StavPosudku)
                .NotNull()
                .SetValidator(new CiselnikPolozkaValidator(context));
            RuleFor(x => x.Posudek.DruhProhlidky)
                .NotNull()
                .SetValidator(new CiselnikPolozkaValidator(context));
            RuleFor(x => x.Posudek.DruhPosudku)
                .NotNull()
                .SetValidator(new CiselnikPolozkaValidator(context));
            RuleFor(x => x.Posudek.Zpusobilosti).NotNull().NotEmpty();
            RuleForEach(x => x.Posudek.Zpusobilosti)
                .ChildRules(z =>
                {
                    z.RuleFor(y => y.SkupinaZadateleRidic)
                        .NotNull()
                        .SetValidator(new CiselnikPolozkaValidator(context));
                    z.RuleFor(y => y.SkupinyRidicskehoOpravneni).NotEmpty();
                    z.RuleFor(y => y.Vysledek)
                        .NotNull()
                        .SetValidator(new CiselnikPolozkaValidator(context));
                    z.RuleForEach(y => y.SkupinyRidicskehoOpravneni)
                        .ChildRules(s =>
                        {
                            s.RuleFor(sk => sk.SkupinaRo)
                                .NotNull()
                                .SetValidator(new CiselnikPolozkaValidator(context));
                        });
                    z.RuleForEach(y => y.HarmonizovaneKody)
                        .ChildRules(h =>
                        {
                            h.RuleFor(hk => hk.HarmonizovanyKod)
                                .NotNull()
                                .SetValidator(new CiselnikPolozkaValidator(context));
                            h.RuleForEach(hk => hk.SkupinaRo)
                                .ChildRules(sr =>
                                {
                                    sr.RuleFor(s => s)
                                        .NotNull()
                                        .SetValidator(new CiselnikPolozkaValidator(context));
                                });
                        });
                    z.RuleForEach(y => y.NarodniKody)
                        .ChildRules(n =>
                        {
                            n.RuleFor(nk => nk.NarodniKod)
                                .NotNull()
                                .SetValidator(new CiselnikPolozkaValidator(context));
                            n.RuleFor(nk => nk.SkupinaRo)
                                .SetValidator(new CiselnikPolozkaValidator(context));
                        });
                });
        }
    }
}

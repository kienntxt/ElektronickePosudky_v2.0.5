using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Validators
{
    public sealed class CiselnikPolozkaValidator
        : AbstractValidator<PosudekRoCiselnikPolozkaCreateDto?>
    {
        private IElektronickePosudkyContext _context;

        public CiselnikPolozkaValidator(IElektronickePosudkyContext context)
        {
            _context = context;
            RuleFor(x => x)
                .NotNull()
                .Must(x =>
                    _context
                        .CiselnikPolozky.AsNoTracking()
                        .Any(e => e.Kod == x!.Kod && e.Verze == x!.Verze)
                )
                .WithMessage(x =>
                    $"Not found codelist (kod: {x!.Kod}, verze: {x!.Verze}) in the database"
                );
        }
    }
}

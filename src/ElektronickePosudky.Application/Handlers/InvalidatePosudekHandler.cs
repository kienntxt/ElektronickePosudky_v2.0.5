using AutoMapper;
using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class InvalidatePosudekHandler
        : IRequestHandler<InvalidatePosudekCommand, PosudekRoDetailDto>
    {
        private readonly IElektronickePosudkyContext _context;
        private readonly IMapper _mapper;

        public InvalidatePosudekHandler(IElektronickePosudkyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PosudekRoDetailDto> Handle(
            InvalidatePosudekCommand request,
            CancellationToken cancellationToken
        )
        {
            var certificate = await _context
                .PosudekRos.Include(x => x.StavPosudku)
                .Include(x => x.TypAkce)
                .Include(x => x.DruhProhlidky)
                .Include(x => x.DruhPosudku)
                .Include(x => x.Vysledek)
                .Include(x => x.SkupinaZadateleRidic)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.SkupinaZadateleRidic)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.Vysledek)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.SkupinyRidicskehoOpravneni)
                .ThenInclude(s => s.SkupinaRo)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.HarmonizovaneKody)
                .ThenInclude(h => h.HarmonizovanyKod)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.NarodniKody)
                .ThenInclude(n => n.NarodniKod)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (certificate == null)
            {
                throw new KeyNotFoundException("PosudekRo not found.");
            }

            var ifMatchBytes = Convert.FromBase64String(request.IfMatch);
            _context.Entry<PosudekRo>(certificate).Property(x => x.RowVersion).OriginalValue =
                ifMatchBytes;

            var invalidItem = await _context.CiselnikPolozky.FirstOrDefaultAsync(
                x => x.Kod == "stav_posudku_3",
                cancellationToken
            );
            if (invalidItem == null)
            {
                throw new InvalidOperationException("Invalidation status item missing.");
            }

            certificate.StavPosudkuId = invalidItem.Id;
            certificate.DatumVytvoreni = DateTime.UtcNow;
            _context.PosudekRoHistories.Add(
                new PosudekRoHistory
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificate.Id,
                    TypOperaceId = invalidItem.Id,
                    DatumOperace = DateTime.UtcNow,
                    KrzpId = certificate.KrzpId,
                }
            );

            await _context.SaveChangesAsync(cancellationToken);

            //refresh changed data including translations
            certificate = await _context
                .PosudekRos.AsNoTracking()
                .Include(x => x.Pacient)
                //lekar
                .Include(x => x.Lekar)
                .ThenInclude(x => x.Odbornost)
                .ThenInclude(x => x!.Translations)
                .Include(x => x.Lekar)
                .ThenInclude(x => x.Poskytovatel)
                //4 codebook-items
                .Include(x => x.StavPosudku)
                .ThenInclude(x => x!.Translations)
                .Include(x => x.TypAkce)
                .ThenInclude(x => x!.Translations)
                .Include(x => x.DruhProhlidky)
                .ThenInclude(x => x!.Translations)
                .Include(x => x.DruhPosudku)
                .ThenInclude(x => x!.Translations)
                .Include(x => x.Vysledek)
                .ThenInclude(x => x!.Translations)
                .Include(x => x.SkupinaZadateleRidic)
                .ThenInclude(x => x!.Translations)
                //lists
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.SkupinaZadateleRidic)
                .ThenInclude(x => x!.Translations)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.Vysledek)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.SkupinyRidicskehoOpravneni)
                .ThenInclude(s => s.SkupinaRo)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.HarmonizovaneKody)
                .ThenInclude(x => x.HarmonizovanyKod)
                .Include(x => x.Zpusobilosti)
                .ThenInclude(z => z.NarodniKody)
                .ThenInclude(n => n.NarodniKod)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            return _mapper.Map<PosudekRoDetailDto>(certificate);
        }
    }
}

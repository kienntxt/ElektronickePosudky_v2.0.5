using AutoMapper;
using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class CreatePosudekHandler
        : IRequestHandler<CreatePosudekCommand, PosudekRoCreateResultDto>
    {
        private readonly IElektronickePosudkyContext _context;
        private readonly IMapper _mapper;

        public CreatePosudekHandler(IElektronickePosudkyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PosudekRoCreateResultDto> Handle(
            CreatePosudekCommand request,
            CancellationToken cancellationToken
        )
        {
            var dto = request.Posudek;
            var certificate = new PosudekRo
            {
                Id = Guid.NewGuid(),
                Rid = dto.Rid ?? Guid.Empty,
                KrzpId = dto.KrzpId ?? Guid.Empty,
                DatumVystaveni = dto.DatumVystaveni,
                PlatnostDo = dto.PlatnostDo,
                OpakovanyPosudekId = dto.OpakovanyPosudekId,
                DatumVytvoreni = DateTime.UtcNow,
            };

            certificate.TypAkceId = await ResolveItemId(dto.TypAkce, cancellationToken);
            certificate.StavPosudkuId = await ResolveItemId(dto.StavPosudku, cancellationToken);
            certificate.DruhProhlidkyId = await ResolveItemId(dto.DruhProhlidky, cancellationToken);
            certificate.DruhPosudkuId = await ResolveItemId(dto.DruhPosudku, cancellationToken);

            foreach (var z in dto.Zpusobilosti ?? Array.Empty<PosudekRoZpusobilostCreateDto>())
            {
                var eligibility = new PosudekRoZpusobilost
                {
                    Id = Guid.NewGuid(),
                    SkupinaZadateleRidicId = await ResolveItemId(
                        z.SkupinaZadateleRidic,
                        cancellationToken
                    ),
                    VysledekId = await ResolveItemId(z.Vysledek, cancellationToken),
                };

                if (z.SkupinyRidicskehoOpravneni != null)
                {
                    foreach (var group in z.SkupinyRidicskehoOpravneni)
                    {
                        eligibility.SkupinyRidicskehoOpravneni.Add(
                            new PosudekRoSkupina
                            {
                                Id = Guid.NewGuid(),
                                SkupinaRoId = await ResolveItemId(
                                    group.SkupinaRo,
                                    cancellationToken
                                ),
                            }
                        );
                    }
                }

                if (z.HarmonizovaneKody != null)
                {
                    foreach (var harmonizovany in z.HarmonizovaneKody)
                    {
                        eligibility.HarmonizovaneKody.Add(
                            new PosudekRoHarmonizovanyKod
                            {
                                Id = Guid.NewGuid(),
                                HarmonizovanyKodId = await ResolveItemId(
                                    harmonizovany.HarmonizovanyKod,
                                    cancellationToken
                                ),
                                UpresneniText = harmonizovany.UpresneniText,
                            }
                        );
                    }
                }

                if (z.NarodniKody != null)
                {
                    foreach (var narodni in z.NarodniKody)
                    {
                        eligibility.NarodniKody.Add(
                            new PosudekRoNarodniKod
                            {
                                Id = Guid.NewGuid(),
                                NarodniKodId = await ResolveItemId(
                                    narodni.NarodniKod,
                                    cancellationToken
                                ),
                                SkupinaRoId = await ResolveItemId(
                                    narodni.SkupinaRo,
                                    cancellationToken
                                ),
                                UpresneniText = narodni.UpresneniText,
                            }
                        );
                    }
                }

                certificate.Zpusobilosti.Add(eligibility);
            }

            _context.PosudekRos.Add(certificate);
            _context.PosudekRoHistories.Add(
                new PosudekRoHistory
                {
                    Id = Guid.NewGuid(),
                    PosudekRoId = certificate.Id,
                    TypOperaceId = certificate.StavPosudkuId ?? Guid.Empty,
                    DatumOperace = DateTime.UtcNow,
                    KrzpId = certificate.KrzpId,
                }
            );

            await _context.SaveChangesAsync(cancellationToken);
            await _context
                .Entry(certificate)
                .Reference(x => x.StavPosudku)
                .LoadAsync(cancellationToken);
            await _context
                .Entry(certificate)
                .Reference(x => x.TypAkce)
                .LoadAsync(cancellationToken);
            await _context
                .Entry(certificate)
                .Reference(x => x.DruhProhlidky)
                .LoadAsync(cancellationToken);
            await _context
                .Entry(certificate)
                .Reference(x => x.DruhPosudku)
                .LoadAsync(cancellationToken);
            await _context
                .Entry(certificate)
                .Reference(x => x.Vysledek)
                .LoadAsync(cancellationToken);
            await _context
                .Entry(certificate)
                .Reference(x => x.SkupinaZadateleRidic)
                .LoadAsync(cancellationToken);

            return _mapper.Map<PosudekRoCreateResultDto>(certificate);
        }

        private async Task<Guid> ResolveItemId(
            PosudekRoCiselnikPolozkaCreateDto? item,
            CancellationToken cancellationToken
        )
        {
            if (item == null || string.IsNullOrEmpty(item.Kod))
            {
                return Guid.Empty;
            }

            var entity = await _context
                .CiselnikPolozky.AsNoTracking()
                .FirstOrDefaultAsync(
                    x => x.Kod == item.Kod && x.Verze == item.Verze,
                    cancellationToken
                );

            return entity?.Id ?? Guid.Empty;
        }
    }
}

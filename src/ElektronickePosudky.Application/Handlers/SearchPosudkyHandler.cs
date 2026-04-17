using AutoMapper;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Application.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class SearchPosudkyHandler
        : IRequestHandler<SearchPosudkyQuery, PosudekRoDetailDtoPageResponse>
    {
        private readonly IElektronickePosudkyContext _context;
        private readonly IMapper _mapper;

        public SearchPosudkyHandler(IElektronickePosudkyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PosudekRoDetailDtoPageResponse> Handle(
            SearchPosudkyQuery request,
            CancellationToken cancellationToken
        )
        {
            // Phase 1: Filter and paginate with lightweight query
            var filterQuery = _context.PosudekRos.AsNoTracking();

            var filter = request.SearchRequest;
            if (filter.Rid.HasValue)
                filterQuery = filterQuery.Where(x => x.Rid == filter.Rid.Value);

            if (filter.DatumOd.HasValue)
                filterQuery = filterQuery.Where(x => x.DatumVystaveni >= filter.DatumOd.Value);

            if (filter.DatumDo.HasValue)
                filterQuery = filterQuery.Where(x => x.DatumVystaveni <= filter.DatumDo.Value);

            if (filter.JenPlatne == true)
            {
                var now = DateTime.UtcNow;
                filterQuery = filterQuery.Where(x => x.PlatnostDo == null || x.PlatnostDo >= now);
            }

            if (!string.IsNullOrWhiteSpace(filter.StavPosudku))
            {
                if (Guid.TryParse(filter.StavPosudku, out var stavId))
                    filterQuery = filterQuery.Where(x => x.StavPosudkuId == stavId);
                else
                    filterQuery = filterQuery.Where(x =>
                        x.StavPosudku != null && x.StavPosudku.Kod == filter.StavPosudku
                    );
            }

            if (!string.IsNullOrWhiteSpace(filter.Ico))
            {
                filterQuery = filterQuery.Where(x =>
                    x.Lekar != null
                    && x.Lekar.Poskytovatel != null
                    && x.Lekar.Poskytovatel.Ico != null
                    && x.Lekar.Poskytovatel.Ico.Contains(filter.Ico)
                );
            }

            if (!string.IsNullOrWhiteSpace(filter.Fulltext))
            {
                filterQuery = filterQuery.Where(x =>
                    x.Rid.ToString().Contains(filter.Fulltext)
                    || x.Pacient != null
                        && x.Pacient.Jmeno != null
                        && x.Pacient.Jmeno.Contains(filter.Fulltext)
                    || x.Pacient != null
                        && x.Pacient.Prijmeni != null
                        && x.Pacient.Prijmeni.Contains(filter.Fulltext)
                    || x.Lekar != null
                        && x.Lekar.Poskytovatel != null
                        && x.Lekar.Poskytovatel.Nazev != null
                        && x.Lekar.Poskytovatel.Nazev.Contains(filter.Fulltext)
                );
            }

            var totalCount = await filterQuery.CountAsync(cancellationToken);
            var page = filter.Page.GetValueOrDefault(1);
            var size = filter.Size.GetValueOrDefault(20);

            var sort = (
                filter.Sort?.ToLowerInvariant(),
                filter.Order?.Equals("asc", StringComparison.OrdinalIgnoreCase) == true
            ) switch
            {
                ("rid", true) => filterQuery.OrderBy(x => x.Rid),
                ("rid", false) => filterQuery.OrderByDescending(x => x.Rid),
                _ => filter.Order?.Equals("asc", StringComparison.OrdinalIgnoreCase) == true
                    ? filterQuery.OrderBy(x => x.DatumVystaveni)
                    : filterQuery.OrderByDescending(x => x.DatumVystaveni),
            };

            // Get IDs only for this page
            var certificateIds = await sort.Skip((page - 1) * size)
                .Take(size)
                .Select(x => x.Id)
                .ToListAsync(cancellationToken);

            // Phase 2a: Load certificates with singular properties only (no collections)
            var pageData = await _context
                .PosudekRos.AsNoTracking()
                .Where(x => certificateIds.Contains(x.Id))
                .Include(x => x.Pacient)
                .Include(x => x.Lekar)
                .ThenInclude(l => l.Odbornost)
                .ThenInclude(o => o!.Translations)
                .Include(x => x.Lekar)
                .ThenInclude(l => l.Poskytovatel)
                .Include(x => x.StavPosudku)
                .ThenInclude(s => s!.Translations)
                .Include(x => x.TypAkce)
                .ThenInclude(t => t!.Translations)
                .Include(x => x.DruhProhlidky)
                .ThenInclude(d => d!.Translations)
                .Include(x => x.DruhPosudku)
                .ThenInclude(d => d!.Translations)
                .Include(x => x.Vysledek)
                .ThenInclude(v => v!.Translations)
                .Include(x => x.SkupinaZadateleRidic)
                .ThenInclude(s => s!.Translations)
                .ToListAsync(cancellationToken);

            // Phase 2b: Load Zpusobilosti (collections) separately for each certificate
            foreach (var certificate in pageData)
            {
                await _context
                    .Entry(certificate)
                    .Collection(c => c.Zpusobilosti)
                    .Query()
                    .Include(z => z.SkupinaZadateleRidic)
                    .ThenInclude(s => s!.Translations)
                    .Include(z => z.Vysledek)
                    .ThenInclude(v => v!.Translations)
                    .Include(z => z.SkupinyRidicskehoOpravneni)
                    .ThenInclude(s => s.SkupinaRo)
                    .ThenInclude(sr => sr!.Translations)
                    .Include(z => z.HarmonizovaneKody)
                    .ThenInclude(h => h.HarmonizovanyKod)
                    .ThenInclude(hk => hk!.Translations)
                    .Include(z => z.NarodniKody)
                    .ThenInclude(n => n.NarodniKod)
                    .ThenInclude(nk => nk!.Translations)
                    .LoadAsync(cancellationToken);
            }

            var items = _mapper.Map<IList<PosudekRoDetailDto>>(pageData);
            return new PosudekRoDetailDtoPageResponse
            {
                PageNumber = page,
                PageSize = size,
                PageCount = (int)Math.Ceiling(totalCount / (double)size),
                TotalCount = totalCount,
                NextPage = page * size < totalCount ? page + 1 : (int?)null,
                Page = items,
            };
        }
    }
}

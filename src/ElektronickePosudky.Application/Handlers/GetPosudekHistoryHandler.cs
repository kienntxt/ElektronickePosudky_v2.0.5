using AutoMapper;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Application.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class GetPosudekHistoryHandler
        : IRequestHandler<GetPosudekHistoryQuery, IReadOnlyList<PosudekRoHistorieDetailDto>>
    {
        private readonly IElektronickePosudkyContext _context;
        private readonly IMapper _mapper;

        public GetPosudekHistoryHandler(IElektronickePosudkyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<PosudekRoHistorieDetailDto>> Handle(
            GetPosudekHistoryQuery request,
            CancellationToken cancellationToken
        )
        {
            var history = await _context
                .PosudekRoHistories.AsNoTracking()
                .Include(x => x.TypOperace)
                .ThenInclude(t => t!.Translations)
                .Include(x => x.Lekar)
                .ThenInclude(l => l.Poskytovatel)
                .Where(x => x.PosudekRoId == request.Id)
                .OrderByDescending(x => x.DatumOperace)
                .ToListAsync(cancellationToken);

            return _mapper.Map<IReadOnlyList<PosudekRoHistorieDetailDto>>(history);
        }
    }
}

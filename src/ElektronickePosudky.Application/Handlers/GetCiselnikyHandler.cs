using AutoMapper;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Application.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class GetCiselnikyHandler
        : IRequestHandler<GetCiselnikyQuery, IReadOnlyList<CiselnikDto>>
    {
        private readonly IElektronickePosudkyContext _context;
        private readonly IMapper _mapper;

        public GetCiselnikyHandler(IElektronickePosudkyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<CiselnikDto>> Handle(
            GetCiselnikyQuery request,
            CancellationToken cancellationToken
        )
        {
            var codebooks = await _context
                .Ciselniky.AsNoTracking()
                .Include(c => c.Translations)
                .ToListAsync(cancellationToken);
            return _mapper.Map<IReadOnlyList<CiselnikDto>>(codebooks);
        }
    }
}

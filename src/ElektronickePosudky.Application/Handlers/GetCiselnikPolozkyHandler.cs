using AutoMapper;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Application.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class GetCiselnikPolozkyHandler
        : IRequestHandler<GetCiselnikPolozkyQuery, IReadOnlyList<CiselnikPolozkaDto>>
    {
        private readonly IElektronickePosudkyContext _context;
        private readonly IMapper _mapper;

        public GetCiselnikPolozkyHandler(IElektronickePosudkyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<CiselnikPolozkaDto>> Handle(
            GetCiselnikPolozkyQuery request,
            CancellationToken cancellationToken
        )
        {
            var items = await _context
                .CiselnikPolozky.AsNoTracking()
                .Include(ci => ci.Translations)
                .Where(x => x.CiselnikKod == request.Kod)
                .ToListAsync(cancellationToken);

            return _mapper.Map<IReadOnlyList<CiselnikPolozkaDto>>(items);
        }
    }
}

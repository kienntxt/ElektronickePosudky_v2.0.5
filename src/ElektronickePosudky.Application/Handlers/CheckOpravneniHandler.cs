using AutoMapper;
using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class CheckOpravneniHandler
        : IRequestHandler<CheckOpravneniCommand, PosudekRoOpravneniResponseDto>
    {
        private readonly IElektronickePosudkyContext _context;
        private readonly IMapper _mapper;

        public CheckOpravneniHandler(IElektronickePosudkyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PosudekRoOpravneniResponseDto> Handle(
            CheckOpravneniCommand request,
            CancellationToken cancellationToken
        )
        {
            var lekar = await _context
                .ZdravotnickyPracovnici.AsNoTracking()
                .Where(x => x.KrzpId == Guid.Parse(request.Request.KrzpId!))
                .Include(x => x.Poskytovatel)
                .FirstOrDefaultAsync();

            return await Task.FromResult(
                new PosudekRoOpravneniResponseDto
                {
                    Opravneni = string.Equals(request.Request.Ico, lekar?.Poskytovatel?.Ico),
                }
            );
        }
    }
}

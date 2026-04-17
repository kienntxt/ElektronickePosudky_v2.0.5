using System.Text;
using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Application.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Application.Handlers
{
    public sealed class GetPosudekPdfHandler : IRequestHandler<GetPosudekPdfQuery, byte[]>
    {
        private readonly IElektronickePosudkyContext _context;

        public GetPosudekPdfHandler(IElektronickePosudkyContext context)
        {
            _context = context;
        }

        public async Task<byte[]> Handle(
            GetPosudekPdfQuery request,
            CancellationToken cancellationToken
        )
        {
            var certificate = await _context
                .PosudekRos.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (certificate == null)
            {
                throw new KeyNotFoundException("PosudekRo not found.");
            }

            var content =
                $"PDF placeholder for certificate {certificate.Id} on {DateTime.UtcNow:O}";
            return Encoding.UTF8.GetBytes(content);
        }
    }
}

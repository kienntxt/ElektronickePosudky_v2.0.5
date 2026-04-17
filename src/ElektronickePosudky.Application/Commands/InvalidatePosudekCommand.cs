using ElektronickePosudky.Application.DTO;
using MediatR;

namespace ElektronickePosudky.Application.Commands
{
    public sealed class InvalidatePosudekCommand : IRequest<PosudekRoDetailDto>
    {
        public Guid Id { get; init; }
        public string IfMatch { get; init; } = string.Empty;
    }
}

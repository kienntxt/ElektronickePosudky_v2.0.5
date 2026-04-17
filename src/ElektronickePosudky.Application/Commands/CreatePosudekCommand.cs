using ElektronickePosudky.Application.DTO;
using MediatR;

namespace ElektronickePosudky.Application.Commands
{
    public sealed class CreatePosudekCommand : IRequest<PosudekRoCreateResultDto>
    {
        public PosudekRoCreateDto Posudek { get; init; } = new();
    }
}

using ElektronickePosudky.Application.DTO;
using MediatR;

namespace ElektronickePosudky.Application.Commands
{
    public sealed class CheckOpravneniCommand : IRequest<PosudekRoOpravneniResponseDto>
    {
        public PosudekRoOpravneniRequestDto Request { get; init; } = new();
    }
}

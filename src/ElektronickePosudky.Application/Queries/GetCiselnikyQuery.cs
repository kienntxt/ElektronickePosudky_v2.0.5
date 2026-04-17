using ElektronickePosudky.Application.DTO;
using MediatR;

namespace ElektronickePosudky.Application.Queries
{
    public sealed class GetCiselnikyQuery : IRequest<IReadOnlyList<CiselnikDto>> { }
}

using ElektronickePosudky.Application.DTO;
using MediatR;

namespace ElektronickePosudky.Application.Queries
{
    public sealed class GetPosudekHistoryQuery : IRequest<IReadOnlyList<PosudekRoHistorieDetailDto>>
    {
        public Guid Id { get; init; }
    }
}

using ElektronickePosudky.Application.DTO;
using MediatR;

namespace ElektronickePosudky.Application.Queries
{
    public sealed class SearchPosudkyQuery : IRequest<PosudekRoDetailDtoPageResponse>
    {
        public PosudkyRoSearchRequest SearchRequest { get; init; } = new();
    }
}

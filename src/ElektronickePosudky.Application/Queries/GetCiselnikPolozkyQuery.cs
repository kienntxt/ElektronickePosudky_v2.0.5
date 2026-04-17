using ElektronickePosudky.Application.DTO;
using MediatR;

namespace ElektronickePosudky.Application.Queries
{
    public sealed class GetCiselnikPolozkyQuery : IRequest<IReadOnlyList<CiselnikPolozkaDto>>
    {
        public string Kod { get; init; } = string.Empty;
    }
}

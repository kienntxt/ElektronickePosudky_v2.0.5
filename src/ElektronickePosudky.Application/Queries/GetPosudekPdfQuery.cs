using MediatR;

namespace ElektronickePosudky.Application.Queries
{
    public sealed class GetPosudekPdfQuery : IRequest<byte[]>
    {
        public Guid Id { get; init; }
    }
}

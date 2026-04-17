namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoDetailDtoPageResponse
    {
        public int PageNumber { get; init; }
        public int PageCount { get; init; }
        public int? NextPage { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public IList<PosudekRoDetailDto>? Page { get; init; }
    }
}

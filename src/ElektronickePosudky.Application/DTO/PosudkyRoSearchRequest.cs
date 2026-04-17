namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudkyRoSearchRequest
    {
        public Guid? Rid { get; init; }
        public DateTime? DatumOd { get; init; }
        public DateTime? DatumDo { get; init; }
        public bool? JenPlatne { get; init; }
        public string? StavPosudku { get; init; }
        public string? Fulltext { get; init; }
        public string? Ico { get; init; }
        public int? Page { get; init; }
        public int? Size { get; init; }
        public string? Sort { get; init; }
        public string? Order { get; init; }
    }
}

namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoNarodniKodDetailDto
    {
        public CiselnikPolozkaWithTranslationsDto? NarodniKod { get; init; }
        public CiselnikPolozkaWithTranslationsDto? SkupinaRo { get; init; }
        public string? UpresneniText { get; init; }
    }
}

namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoHarmonizovanyKodDetailDto
    {
        public CiselnikPolozkaWithTranslationsDto? HarmonizovanyKod { get; init; }
        public IList<CiselnikPolozkaWithTranslationsDto>? SkupinaRo { get; init; }
        public CiselnikPolozkaWithTranslationsDto? UpresneniKod { get; init; }
        public string? UpresneniText { get; init; }
    }
}

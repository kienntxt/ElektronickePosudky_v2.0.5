namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoHarmonizovanyKodCreateDto
    {
        public PosudekRoCiselnikPolozkaCreateDto? HarmonizovanyKod { get; init; }
        public IList<PosudekRoCiselnikPolozkaCreateDto>? SkupinaRo { get; init; }
        public string? UpresneniText { get; init; }
    }
}

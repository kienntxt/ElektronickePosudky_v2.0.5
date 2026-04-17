namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoNarodniKodCreateDto
    {
        public PosudekRoCiselnikPolozkaCreateDto? NarodniKod { get; init; }
        public PosudekRoCiselnikPolozkaCreateDto? SkupinaRo { get; init; }
        public string? UpresneniText { get; init; }
    }
}

namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoZpusobilostCreateDto
    {
        public PosudekRoCiselnikPolozkaCreateDto? SkupinaZadateleRidic { get; init; }
        public IList<PosudekRoSkupinaCreateDto>? SkupinyRidicskehoOpravneni { get; init; }
        public PosudekRoCiselnikPolozkaCreateDto? Vysledek { get; init; }
        public IList<PosudekRoHarmonizovanyKodCreateDto>? HarmonizovaneKody { get; init; }
        public IList<PosudekRoNarodniKodCreateDto>? NarodniKody { get; init; }
    }
}

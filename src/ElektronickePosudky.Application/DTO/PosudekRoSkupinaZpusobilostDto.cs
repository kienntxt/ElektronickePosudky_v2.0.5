namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoSkupinaZpusobilostDto
    {
        public Guid PosudekId { get; init; }
        public CiselnikPolozkaWithTranslationsDto? SkupinaZadateleRidic { get; init; }
        public IList<PosudekRoSkupinaDetailDto>? SkupinyRidicskehoOpravneni { get; init; }
        public CiselnikPolozkaWithTranslationsDto? Vysledek { get; init; }
        public IList<PosudekRoHarmonizovanyKodDetailDto>? HarmonizovaneKody { get; init; }
        public IList<PosudekRoNarodniKodDetailDto>? NarodniKody { get; init; }
        public string? VerzeZaznamu { get; init; }
    }
}

namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoDetailDto
    {
        public Guid Id { get; init; }
        public PacientDto? Pacient { get; init; }
        public ZdravotnickyPracovnikDetailDto? ZdravotnickyPracovnik { get; init; }
        public PoskytovatelZdravotnickychSluzebDetailDto? PoskytovatelZdravotnickychSluzeb { get; init; }
        public CiselnikPolozkaWithTranslationsDto? OdbornostLekare { get; init; }
        public CiselnikPolozkaWithTranslationsDto? StavPosudku { get; init; }
        public CiselnikPolozkaWithTranslationsDto? DruhProhlidky { get; init; }
        public CiselnikPolozkaWithTranslationsDto? DruhPosudku { get; init; }
        public CiselnikPolozkaWithTranslationsDto? Vysledek { get; init; }
        public CiselnikPolozkaWithTranslationsDto? SkupinaZadatelRidic { get; init; }
        public DateTime DatumVystaveni { get; init; }
        public DateTime? PlatnostDo { get; init; }
        public DateTime DatumVytvoreni { get; init; }
        public IList<PosudekRoSkupinaDetailDto>? SkupinyRidicskehoOpravneni { get; init; }
        public IList<PosudekRoHarmonizovanyKodDetailDto>? HarmonizovaneKody { get; init; }
        public IList<PosudekRoNarodniKodDetailDto>? NarodniKody { get; init; }
        public string? VerzeZaznamu { get; init; }
    }
}

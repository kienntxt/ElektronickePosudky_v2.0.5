namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoHlavickaDetailDto
    {
        public PacientDto? Pacient { get; init; }
        public ZdravotnickyPracovnikDetailDto? ZdravotnickyPracovnik { get; init; }
        public PoskytovatelZdravotnickychSluzebDetailDto? PoskytovatelZdravotnickychSluzeb { get; init; }
        public CiselnikPolozkaWithTranslationsDto? OdbornostLekare { get; init; }
        public CiselnikPolozkaWithTranslationsDto? StavPosudku { get; init; }
        public CiselnikPolozkaWithTranslationsDto? DruhProhlidky { get; init; }
        public CiselnikPolozkaWithTranslationsDto? DruhPosudku { get; init; }
        public DateTime DatumVystaveni { get; init; }
        public DateTime? PlatnostDo { get; init; }
        public DateTime DatumVytvoreni { get; init; }
    }
}

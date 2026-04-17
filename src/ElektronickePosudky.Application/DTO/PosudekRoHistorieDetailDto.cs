namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoHistorieDetailDto
    {
        public CiselnikPolozkaWithTranslationsDto? TypOperace { get; init; }
        public DateTime DatumOperace { get; init; }
        public ZdravotnickyPracovnikDetailDto? Lekar { get; init; }
        public PoskytovatelZdravotnickychSluzebDetailDto? Poskytovatel { get; init; }
    }
}

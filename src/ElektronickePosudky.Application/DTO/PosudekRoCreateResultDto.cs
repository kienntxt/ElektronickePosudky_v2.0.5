namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoCreateResultDto
    {
        public PosudekRoHlavickaDetailDto? Hlavicka { get; init; }
        public IList<PosudekRoSkupinaZpusobilostDto>? Zpusobilosti { get; init; }
    }
}

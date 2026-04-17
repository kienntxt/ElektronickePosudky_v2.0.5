namespace ElektronickePosudky.Application.DTO
{
    public sealed class PosudekRoCreateDto
    {
        public Guid? Rid { get; init; }
        public Guid? KrzpId { get; init; }
        public PosudekRoCiselnikPolozkaCreateDto? TypAkce { get; init; }
        public PosudekRoCiselnikPolozkaCreateDto? StavPosudku { get; init; }
        public PosudekRoCiselnikPolozkaCreateDto? DruhProhlidky { get; init; }
        public PosudekRoCiselnikPolozkaCreateDto? DruhPosudku { get; init; }
        public DateTime DatumVystaveni { get; init; }
        public DateTime? PlatnostDo { get; init; }
        public Guid? OpakovanyPosudekId { get; init; }
        public IList<PosudekRoZpusobilostCreateDto>? Zpusobilosti { get; init; }
    }
}

namespace ElektronickePosudky.Application.DTO
{
    public sealed class PacientDto
    {
        public Guid Rid { get; init; }
        public string? Jmeno { get; init; }
        public string? Prijmeni { get; init; }
        public DateTime? DatumNarozeni { get; init; }
        public string? Adresa { get; init; }
        public string? Email { get; init; }
        public string? Doklad { get; init; }
        public string? Pohlavi { get; init; }
    }
}

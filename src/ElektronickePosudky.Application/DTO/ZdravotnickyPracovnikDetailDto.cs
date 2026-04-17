namespace ElektronickePosudky.Application.DTO
{
    public sealed class ZdravotnickyPracovnikDetailDto
    {
        public Guid KrzpId { get; init; }
        public string? Jmeno { get; init; }
        public string? Prijmeni { get; init; }
        public string? OdbornostLekare { get; init; }
    }
}

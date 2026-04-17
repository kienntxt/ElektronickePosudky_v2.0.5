namespace ElektronickePosudky.Domain.Entities
{
    public sealed class CiselnikPolozka
    {
        public Guid Id { get; set; }
        public Guid CiselnikId { get; set; }
        public Ciselnik? Ciselnik { get; set; }
        public string Kod { get; set; } = null!;
        public string? Verze { get; set; }
        public Guid? RodicId { get; set; }
        public CiselnikPolozka? Rodic { get; set; }
        public string CiselnikKod { get; set; } = null!;
        public string? CiselnikVerze { get; set; }
        public ICollection<Translation> Translations { get; set; } = new List<Translation>();
    }
}

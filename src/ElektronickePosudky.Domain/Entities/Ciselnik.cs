namespace ElektronickePosudky.Domain.Entities
{
    public sealed class Ciselnik
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string? Verze { get; set; }
        public DateTime PlatnostOd { get; set; }
        public DateTime? PlatnostDo { get; set; }
        public bool? Termx { get; set; }
        public string? TermxId { get; set; }
        public string? TermxUrl { get; set; }
        public ICollection<CiselnikPolozka> Items { get; set; } = new List<CiselnikPolozka>();
        public ICollection<Translation> Translations { get; set; } = new List<Translation>();
    }
}

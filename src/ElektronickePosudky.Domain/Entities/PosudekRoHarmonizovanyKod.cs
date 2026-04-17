namespace ElektronickePosudky.Domain.Entities
{
    public sealed class PosudekRoHarmonizovanyKod
    {
        public Guid Id { get; set; }
        public Guid PosudekRoZpusobilostId { get; set; }
        public PosudekRoZpusobilost? PosudekRoZpusobilost { get; set; }
        public Guid HarmonizovanyKodId { get; set; }
        public CiselnikPolozka? HarmonizovanyKod { get; set; }
        public string? UpresneniText { get; set; }
    }
}

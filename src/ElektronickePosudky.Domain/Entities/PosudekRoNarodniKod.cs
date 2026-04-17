namespace ElektronickePosudky.Domain.Entities
{
    public sealed class PosudekRoNarodniKod
    {
        public Guid Id { get; set; }
        public Guid PosudekRoZpusobilostId { get; set; }
        public PosudekRoZpusobilost? PosudekRoZpusobilost { get; set; }
        public Guid NarodniKodId { get; set; }
        public CiselnikPolozka? NarodniKod { get; set; }
        public Guid? SkupinaRoId { get; set; }
        public CiselnikPolozka? SkupinaRo { get; set; }
        public string? UpresneniText { get; set; }
    }
}

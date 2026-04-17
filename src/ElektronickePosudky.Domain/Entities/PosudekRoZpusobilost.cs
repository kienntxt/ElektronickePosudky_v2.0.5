namespace ElektronickePosudky.Domain.Entities
{
    public sealed class PosudekRoZpusobilost
    {
        public Guid Id { get; set; }
        public Guid PosudekRoId { get; set; }
        public PosudekRo? PosudekRo { get; set; }
        public Guid SkupinaZadateleRidicId { get; set; }
        public CiselnikPolozka? SkupinaZadateleRidic { get; set; }
        public Guid VysledekId { get; set; }
        public CiselnikPolozka? Vysledek { get; set; }
        public ICollection<PosudekRoSkupina> SkupinyRidicskehoOpravneni { get; set; } = [];
        public ICollection<PosudekRoHarmonizovanyKod> HarmonizovaneKody { get; set; } = [];
        public ICollection<PosudekRoNarodniKod> NarodniKody { get; set; } = [];
        public byte[]? RowVersion { get; set; }
    }
}

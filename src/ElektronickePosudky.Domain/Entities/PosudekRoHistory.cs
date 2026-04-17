namespace ElektronickePosudky.Domain.Entities
{
    public sealed class PosudekRoHistory
    {
        public Guid Id { get; set; }
        public Guid PosudekRoId { get; set; }
        public PosudekRo? PosudekRo { get; set; }
        public Guid TypOperaceId { get; set; }
        public CiselnikPolozka? TypOperace { get; set; }
        public DateTime DatumOperace { get; set; }

        /// <summary>
        /// Doctor ID
        /// </summary>
        public Guid KrzpId { get; set; }
        public ZdravotnickyPracovnik Lekar { get; set; } = null!;
    }
}

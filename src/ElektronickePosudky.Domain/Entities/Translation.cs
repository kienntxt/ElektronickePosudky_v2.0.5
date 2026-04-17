namespace ElektronickePosudky.Domain.Entities
{
    public sealed class Translation
    {
        public Guid Id { get; set; }
        public string EntityType { get; set; } = null!;
        public Guid EntityId { get; set; }
        public Guid? CiselnikId { get; set; }
        public Ciselnik? Ciselnik { get; set; }
        public Guid? CiselnikPolozkaId { get; set; }
        public CiselnikPolozka? CiselnikPolozka { get; set; }
        public string Language { get; set; } = null!;
        public string PropertyName { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}

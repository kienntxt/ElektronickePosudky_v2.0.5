namespace ElektronickePosudky.Application.DTO
{
    public sealed class CiselnikDto
    {
        public Guid Id { get; init; }
        public string? Kod { get; init; }
        public string? Verze { get; init; }
        public DateTime PlatnostOd { get; init; }
        public DateTime? PlatnostDo { get; init; }
        public bool? Termx { get; init; }
        public string? TermxId { get; init; }
        public string? TermxUrl { get; init; }
        public IDictionary<string, TranslationDto>? Preklady { get; init; }
    }
}

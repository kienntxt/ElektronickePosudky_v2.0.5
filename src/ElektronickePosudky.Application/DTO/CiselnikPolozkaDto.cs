namespace ElektronickePosudky.Application.DTO
{
    public sealed class CiselnikPolozkaDto
    {
        public Guid Id { get; init; }
        public string? Kod { get; init; }
        public string? Verze { get; init; }
        public Guid? RodicId { get; init; }
        public IDictionary<string, TranslationDto>? Preklady { get; init; }
    }
}

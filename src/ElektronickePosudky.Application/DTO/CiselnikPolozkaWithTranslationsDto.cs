namespace ElektronickePosudky.Application.DTO
{
    public sealed class CiselnikPolozkaWithTranslationsDto
    {
        public string? CiselnikKod { get; init; }
        public string? CiselnikVerze { get; init; }
        public string? PolozkaKod { get; init; }
        public IDictionary<string, TranslationDto>? Preklady { get; init; }
    }
}

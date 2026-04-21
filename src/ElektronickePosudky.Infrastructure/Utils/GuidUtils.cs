namespace ElektronickePosudky.Infrastructure.Utils
{
    public static class GuidUtils
    {
        public const int CiselnikPrefix = 1;
        public const int CiselnikPolozkaPrefix = 2;
        public const int TranslationPrefix = 3;

        public const int PacientPrefix = 4;
        public const int ZdravotnickyPracovnikPrefix = 5;
        public const int PoskytovatelZdravotnickychSluzebPrefix = 6;

        /// <summary>
        /// Generate special GUID via formatting
        /// <br/>"{entityPrefix:D8}-{group:D4}-0000-0000-{number:D12}"
        /// </summary>
        public static Guid Generate(
            int entityPrefix,
            int number,
            CiselnikType group = CiselnikType.None
        ) => Guid.Parse($"{entityPrefix:D8}-{(int)group:D4}-0000-0000-{number:D12}");
    }
}

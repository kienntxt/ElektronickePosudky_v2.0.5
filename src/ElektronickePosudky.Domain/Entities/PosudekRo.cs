using System.ComponentModel.DataAnnotations;

namespace ElektronickePosudky.Domain.Entities
{
    public sealed class PosudekRo
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Patient ID
        /// </summary>
        public Guid Rid { get; set; }
        public Pacient Pacient { get; set; } = null!;

        /// <summary>
        /// Doctor ID
        /// </summary>
        public Guid KrzpId { get; set; }
        public ZdravotnickyPracovnik Lekar { get; set; } = null!;

        public Guid? StavPosudkuId { get; set; }
        public CiselnikPolozka? StavPosudku { get; set; }
        public Guid? DruhProhlidkyId { get; set; }
        public CiselnikPolozka? DruhProhlidky { get; set; }
        public Guid? DruhPosudkuId { get; set; }
        public CiselnikPolozka? DruhPosudku { get; set; }
        public Guid? TypAkceId { get; set; }
        public CiselnikPolozka? TypAkce { get; set; }
        public Guid? VysledekId { get; set; }
        public CiselnikPolozka? Vysledek { get; set; }
        public Guid? SkupinaZadateleRidicId { get; set; }
        public CiselnikPolozka? SkupinaZadateleRidic { get; set; }
        public DateTime DatumVystaveni { get; set; }
        public DateTime? PlatnostDo { get; set; }
        public Guid? OpakovanyPosudekId { get; set; }
        public DateTime DatumVytvoreni { get; set; }

        [Timestamp]
        public byte[]? RowVersion { get; set; }
        public ICollection<PosudekRoZpusobilost> Zpusobilosti { get; set; } = [];
        public ICollection<PosudekRoHistory> Historie { get; set; } = [];
    }
}

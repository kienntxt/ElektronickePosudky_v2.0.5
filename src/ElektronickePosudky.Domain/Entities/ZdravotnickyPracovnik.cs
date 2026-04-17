using System.ComponentModel.DataAnnotations;

namespace ElektronickePosudky.Domain.Entities
{
    public sealed class ZdravotnickyPracovnik
    {
        [Key]
        public Guid KrzpId { get; set; }
        public string Jmeno { get; set; } = null!;
        public string Prijmeni { get; set; } = null!;

        public Guid OdbornostId { get; set; }
        public CiselnikPolozka? Odbornost { get; set; } = null!;

        public Guid PoskytovatelId { get; set; }
        public PoskytovatelZdravotnickychSluzeb? Poskytovatel { get; set; }
    }
}

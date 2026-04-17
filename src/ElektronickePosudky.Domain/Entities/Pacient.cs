using System.ComponentModel.DataAnnotations;

namespace ElektronickePosudky.Domain.Entities
{
    public sealed class Pacient
    {
        [Key]
        public Guid Rid { get; set; }
        public string Jmeno { get; set; } = null!;
        public string Prijmeni { get; set; } = null!;
        public DateTime DatumNarozeni { get; set; }
        public string? Adresa { get; set; }
        public string? Email { get; set; }
        public string? Doklad { get; set; }
        public string? Pohlavi { get; set; }
    }
}

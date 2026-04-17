using System.ComponentModel.DataAnnotations;

namespace ElektronickePosudky.Domain.Entities
{
    public sealed class PoskytovatelZdravotnickychSluzeb
    {
        [Key]
        public Guid Id { get; set; }

        public string? Ico { get; set; } = null!;
        public string? Nazev { get; set; } = null!;
        public string? Adresa { get; set; } = null!;

        public ICollection<ZdravotnickyPracovnik> Lekary = [];
    }
}

using System.ComponentModel.DataAnnotations;
using ElektronickePosudky.Domain.Entities;

namespace ElektronickePosudky.Infrastructure.Utils
{
    public record JsonCodebook(
        int id,
        string version,
        string valueSet,
        DateTime releaseDate,
        ExpansionSnapshot snapshot
    );

    public record ExpansionSnapshot(IList<Expansion> expansion);

    public record Expansion(
        Concept concept,
        Display display,
        IList<AdditionalDesignation> additionalDesignations
    );

    public record Concept(string code);

    public record Display(int id, string name, string language = "cs");

    public record AdditionalDesignation(string name, bool preferred = true, string language = "cs");

    public record CodebookResult(
        Ciselnik codebook,
        IList<CiselnikPolozka> items,
        IList<Translation> translations
    );
}

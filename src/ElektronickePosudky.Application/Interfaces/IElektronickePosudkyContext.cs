using ElektronickePosudky.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ElektronickePosudky.Application.Interfaces;

public interface IElektronickePosudkyContext
{
    /// <summary>
    /// Codebooks
    /// </summary>
    DbSet<Ciselnik> Ciselniky { get; }

    /// <summary>
    /// CodebookItems
    /// </summary>
    DbSet<CiselnikPolozka> CiselnikPolozky { get; }

    /// <summary>
    /// Patients
    /// </summary>
    DbSet<Pacient> Pacienti { get; }

    /// <summary>
    /// Healthcare Employees
    /// </summary>
    DbSet<ZdravotnickyPracovnik> ZdravotnickyPracovnici { get; }

    /// <summary>
    /// Healthcare Service Providers
    /// </summary>
    DbSet<PoskytovatelZdravotnickychSluzeb> PoskytovateleZdravotnickychSluzeb { get; }

    /// <summary>
    /// Certificate
    /// </summary>
    DbSet<PosudekRo> PosudekRos { get; }

    /// <summary>
    /// Qualifications
    /// </summary>
    DbSet<PosudekRoZpusobilost> PosudekRoZpusobilosti { get; }

    /// <summary>
    /// Groups
    /// </summary>
    DbSet<PosudekRoSkupina> PosudekRoSkupiny { get; }

    /// <summary>
    ///
    /// </summary>
    DbSet<PosudekRoHarmonizovanyKod> PosudekRoHarmonizovaneKody { get; }

    /// <summary>
    /// National Codes
    /// </summary>
    DbSet<PosudekRoNarodniKod> PosudekRoNarodniKody { get; }

    /// <summary>
    /// Histories
    /// </summary>
    DbSet<PosudekRoHistory> PosudekRoHistories { get; }

    DbSet<Translation> Translations { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
        where TEntity : class;
}

using ElektronickePosudky.Application.Interfaces;
using ElektronickePosudky.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElektronickePosudky.Infrastructure.Persistence
{
    public sealed class ElektronickePosudkyContext : DbContext, IElektronickePosudkyContext
    {
        public ElektronickePosudkyContext(DbContextOptions<ElektronickePosudkyContext> options)
            : base(options) { }

        public DbSet<Ciselnik> Ciselniky => Set<Ciselnik>();
        public DbSet<CiselnikPolozka> CiselnikPolozky => Set<CiselnikPolozka>();
        public DbSet<Pacient> Pacienti => Set<Pacient>();
        public DbSet<ZdravotnickyPracovnik> ZdravotnickyPracovnici => Set<ZdravotnickyPracovnik>();
        public DbSet<PoskytovatelZdravotnickychSluzeb> PoskytovateleZdravotnickychSluzeb =>
            Set<PoskytovatelZdravotnickychSluzeb>();
        public DbSet<PosudekRo> PosudekRos => Set<PosudekRo>();
        public DbSet<PosudekRoZpusobilost> PosudekRoZpusobilosti => Set<PosudekRoZpusobilost>();
        public DbSet<PosudekRoSkupina> PosudekRoSkupiny => Set<PosudekRoSkupina>();
        public DbSet<PosudekRoHarmonizovanyKod> PosudekRoHarmonizovaneKody =>
            Set<PosudekRoHarmonizovanyKod>();
        public DbSet<PosudekRoNarodniKod> PosudekRoNarodniKody => Set<PosudekRoNarodniKod>();
        public DbSet<PosudekRoHistory> PosudekRoHistories => Set<PosudekRoHistory>();
        public DbSet<Translation> Translations => Set<Translation>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ciselnik>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity
                    .HasMany(x => x.Items)
                    .WithOne(x => x.Ciselnik!)
                    .HasForeignKey(x => x.CiselnikId);
                entity
                    .HasMany(x => x.Translations)
                    .WithOne(x => x.Ciselnik)
                    .HasForeignKey(x => x.CiselnikId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<CiselnikPolozka>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity
                    .HasOne(x => x.Rodic)
                    .WithMany()
                    .HasForeignKey(x => x.RodicId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(x => new { x.CiselnikId, x.Kod }).IsUnique();
                entity
                    .HasMany(x => x.Translations)
                    .WithOne(x => x.CiselnikPolozka)
                    .HasForeignKey(x => x.CiselnikPolozkaId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Translation>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity
                    .HasIndex(x => new
                    {
                        x.EntityType,
                        x.EntityId,
                        x.Language,
                        x.PropertyName,
                    })
                    .IsUnique();
            });

            modelBuilder.Entity<PosudekRo>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.RowVersion).IsRowVersion();
                entity
                    .HasMany(x => x.Zpusobilosti)
                    .WithOne(x => x.PosudekRo!)
                    .HasForeignKey(x => x.PosudekRoId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity
                    .HasMany(x => x.Historie)
                    .WithOne(x => x.PosudekRo!)
                    .HasForeignKey(x => x.PosudekRoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PosudekRoZpusobilost>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.RowVersion).IsRowVersion();
                entity
                    .HasOne(x => x.SkupinaZadateleRidic)
                    .WithMany()
                    .HasForeignKey(x => x.SkupinaZadateleRidicId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .HasOne(x => x.Vysledek)
                    .WithMany()
                    .HasForeignKey(x => x.VysledekId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .HasMany(x => x.SkupinyRidicskehoOpravneni)
                    .WithOne(x => x.PosudekRoZpusobilost!)
                    .HasForeignKey(x => x.PosudekRoZpusobilostId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity
                    .HasMany(x => x.HarmonizovaneKody)
                    .WithOne(x => x.PosudekRoZpusobilost!)
                    .HasForeignKey(x => x.PosudekRoZpusobilostId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity
                    .HasMany(x => x.NarodniKody)
                    .WithOne(x => x.PosudekRoZpusobilost!)
                    .HasForeignKey(x => x.PosudekRoZpusobilostId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PosudekRoSkupina>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity
                    .HasOne(x => x.SkupinaRo)
                    .WithMany()
                    .HasForeignKey(x => x.SkupinaRoId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PosudekRoHarmonizovanyKod>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity
                    .HasOne(x => x.HarmonizovanyKod)
                    .WithMany()
                    .HasForeignKey(x => x.HarmonizovanyKodId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PosudekRoNarodniKod>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity
                    .HasOne(x => x.NarodniKod)
                    .WithMany()
                    .HasForeignKey(x => x.NarodniKodId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .HasOne(x => x.SkupinaRo)
                    .WithMany()
                    .HasForeignKey(x => x.SkupinaRoId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PosudekRoHistory>(entity =>
            {
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Pacient>(entity =>
            {
                entity.HasKey(x => x.Rid);
                entity.Property(x => x.Rid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZdravotnickyPracovnik>(entity =>
            {
                entity.HasKey(x => x.KrzpId);
                entity.Property(x => x.KrzpId).ValueGeneratedNever();
                entity
                    .HasOne(x => x.Odbornost)
                    .WithMany()
                    .HasForeignKey(x => x.OdbornostId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .HasOne(x => x.Poskytovatel)
                    .WithMany(x => x.Lekary)
                    .HasForeignKey(x => x.PoskytovatelId);
            });

            modelBuilder.Entity<PoskytovatelZdravotnickychSluzeb>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PosudekRo>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.RowVersion).IsRowVersion();
                entity
                    .HasOne(x => x.Pacient)
                    .WithMany()
                    .HasForeignKey(x => x.Rid)
                    .OnDelete(DeleteBehavior.Restrict);
                entity
                    .HasOne(x => x.Lekar)
                    .WithMany()
                    .HasForeignKey(x => x.KrzpId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity
                    .HasMany(x => x.Zpusobilosti)
                    .WithOne(x => x.PosudekRo!)
                    .HasForeignKey(x => x.PosudekRoId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity
                    .HasMany(x => x.Historie)
                    .WithOne(x => x.PosudekRo!)
                    .HasForeignKey(x => x.PosudekRoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PosudekRoHistory>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity
                    .HasOne(x => x.TypOperace)
                    .WithMany()
                    .HasForeignKey(x => x.TypOperaceId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .HasOne(x => x.Lekar)
                    .WithMany()
                    .HasForeignKey(x => x.KrzpId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Seed();
        }
    }
}

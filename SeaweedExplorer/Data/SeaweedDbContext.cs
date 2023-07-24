using Microsoft.EntityFrameworkCore;
using SeaweedExplorer.Data.Models;

namespace SeaweedExplorer.Data
{
    public class SeaweedDbContext : DbContext
    {
        public SeaweedDbContext(
            DbContextOptions<SeaweedDbContext> options) : base(options) { }

        public DbSet<Seaweed> Seaweed => Set<Seaweed>();
        public DbSet<SeaweedClass> SeaweedClass => Set<SeaweedClass>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SeaweedClass>().HasData(
                new SeaweedClass { Id = 1, NameCommon = "Rødalge", NameLatin = "Chondrus crispus" },
                new SeaweedClass { Id = 2, NameCommon = "Brunalge", NameLatin = "Laminaria digitata" },
                new SeaweedClass { Id = 3, NameCommon = "Grønalge", NameLatin = "Ulva lactuca" });

            modelBuilder.Entity<Seaweed>().HasData(
                new Seaweed { Id = 1, NameCommon = "Tarmrørhinde", NameLatin = "", Native = true, SeaweedClassId = 3 },
                new Seaweed { Id = 2, NameCommon = "Søl", NameLatin = "", Native = true, SeaweedClassId = 1 },
                new Seaweed { Id = 3, NameCommon = "Carrageentang", NameLatin = "", Native = true, SeaweedClassId = 1 },
                new Seaweed { Id = 4, NameCommon = "Gaffeltang", NameLatin = "", Native = true, SeaweedClassId = 1 },
                new Seaweed { Id = 5, NameCommon = "Fingertang", NameLatin = "", Native = true, SeaweedClassId = 2 },
                new Seaweed { Id = 6, NameCommon = "Sukkertang", NameLatin = "", Native = true, SeaweedClassId = 2 },
                new Seaweed { Id = 7, NameCommon = "Blæretang", NameLatin = "", Native = true, SeaweedClassId = 2 },
                new Seaweed { Id = 8, NameCommon = "Savtang", NameLatin = "", Native = true, SeaweedClassId = 2 });
        }
    }
}

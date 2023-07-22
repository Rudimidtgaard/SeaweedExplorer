using Microsoft.EntityFrameworkCore;
using SeaweedExplorer.Data.Models;

namespace SeaweedExplorer.Data
{
    public class SeeweedDbContext : DbContext
    {
        public SeeweedDbContext(
            DbContextOptions<SeeweedDbContext> options) : base(options) { }

        public DbSet<Seeweed> Seeweed => Set<Seeweed>();
        public DbSet<SeeweedClass> SeeweedClass => Set<SeeweedClass>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SeeweedClass>().HasData(
                new SeeweedClass { Id = 1, NameCommon = "Rødalge", NameLatin = "Chondrus crispus" },
                new SeeweedClass { Id = 2, NameCommon = "Brunalge", NameLatin = "Laminaria digitata" },
                new SeeweedClass { Id = 3, NameCommon = "Grønalge", NameLatin = "Ulva lactuca" });

            modelBuilder.Entity<Seeweed>().HasData(
                new Seeweed { Id = 1, NameCommon = "Tarmrørhinde", NameLatin = "", Native = true, SeeweedClassId = 3 },
                new Seeweed { Id = 2, NameCommon = "Søl", NameLatin = "", Native = true, SeeweedClassId = 1 },
                new Seeweed { Id = 3, NameCommon = "Carrageentang", NameLatin = "", Native = true, SeeweedClassId = 1 },
                new Seeweed { Id = 4, NameCommon = "Gaffeltang", NameLatin = "", Native = true, SeeweedClassId = 1 },
                new Seeweed { Id = 5, NameCommon = "Fingertang", NameLatin = "", Native = true, SeeweedClassId = 2 },
                new Seeweed { Id = 6, NameCommon = "Sukkertang", NameLatin = "", Native = true, SeeweedClassId = 2 },
                new Seeweed { Id = 7, NameCommon = "Blæretang", NameLatin = "", Native = true, SeeweedClassId = 2 },
                new Seeweed { Id = 8, NameCommon = "Savtang", NameLatin = "", Native = true, SeeweedClassId = 2 });
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DnD35EDMTools.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for your entities
        public DbSet<CharacterData> Characters { get; set; }
        public DbSet<RaceData> Races { get; set; }
        public DbSet<ColourData> Colours { get; set; }
        public DbSet<FeatsTraitsData> FeatsTraits { get; set; }
        public DbSet<SpellsSLAData> SpellsSla { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.EyeColours)
                    .WithMany(c => c.RaceEyeColours)
                    .UsingEntity(joinEntity =>
                {
                    joinEntity.ToTable("RaceEyeColourJoinTable");
                });
                
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.HairColours)
                    .WithMany(c => c.RaceHairColours)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("RaceHairColourJoinTable");
                    });
                
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.SkinColours)
                    .WithMany(c => c.RaceSkinColours)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("RaceSkinColourJoinTable");
                    });
            }
    }
}
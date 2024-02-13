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
                    joinEntity.HasNoKey();
                });
                
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.HairColours)
                    .WithMany(c => c.RaceHairColours)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("RaceHairColourJoinTable");
                        joinEntity.HasNoKey();
                    });
                
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.SkinColours)
                    .WithMany(c => c.RaceSkinColours)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("RaceSkinColourJoinTable");
                        joinEntity.HasNoKey();
                    });
            }
        // {
        //     base.OnModelCreating(modelBuilder);
        //
        //     modelBuilder.Entity<EyeColourData>()
        //         .HasKey(rc => new { rc.RaceId, rc.EyeColourId });
        //
        //     modelBuilder.Entity<HairColourData>()
        //         .HasKey(rc => new { rc.RaceId, rc.HairColourId });
        //
        //     modelBuilder.Entity<SkinColourData>()
        //         .HasKey(rc => new { rc.RaceId, rc.SkinColourId });
        //
        //     // Configure relationships
        //     modelBuilder.Entity<EyeColourData>()
        //         .HasOne(rc => rc.Race)
        //         .WithMany(r => r.EyeColours) // Assuming EyeColours is the collection of EyeColourData in RaceData
        //         .HasForeignKey(rc => rc.RaceId);
        //
        //     modelBuilder.Entity<EyeColourData>()
        //         .HasOne(rc => rc.EyeColour)
        //         .WithMany() // Assuming there's no collection navigation property in EyeColourData back to RaceEyeColour
        //         .HasForeignKey(rc => rc.EyeColourId);
        //
        //     modelBuilder.Entity<HairColourData>()
        //         .HasOne(rc => rc.Race)
        //         .WithMany(r => r.HairColours) // Assuming HairColours is the collection of HairColourData in RaceData
        //         .HasForeignKey(rc => rc.RaceId);
        //
        //     modelBuilder.Entity<HairColourData>()
        //         .HasOne(rc => rc.HairColour)
        //         .WithMany() // Assuming there's no collection navigation property in HairColourData back to RaceHairColour
        //         .HasForeignKey(rc => rc.HairColourId);
        //
        //     modelBuilder.Entity<SkinColourData>()
        //         .HasOne(rc => rc.Race)
        //         .WithMany(r => r.SkinColours) // Assuming SkinColours is the collection of SkinColourData in RaceData
        //         .HasForeignKey(rc => rc.RaceId);
        //
        //     modelBuilder.Entity<SkinColourData>()
        //         .HasOne(rc => rc.SkinColour)
        //         .WithMany() // Assuming there's no collection navigation property in SkinColourData back to RaceSkinColour
        //         .HasForeignKey(rc => rc.SkinColourId);
        // }
    }
}
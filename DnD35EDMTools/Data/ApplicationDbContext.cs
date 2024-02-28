using DnD35EDMTools.Migrations;
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
        public DbSet<GenderData> Genders { get; set; }
        public DbSet<AlignmentData> Alignments { get; set; }
        public DbSet<DeityData> Deities { get; set; }
        public DbSet<OrderData> Orders { get; set; }
        public DbSet<MoralityData> Moralities { get; set; }
        public DbSet<ClassData> Classes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.EyeColours)
                    .WithMany(c => c.RaceEyeColours)
                    .UsingEntity(joinEntity =>
                {
                    joinEntity.ToTable("JoinTableRaceEyeColour");
                });
                
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.HairColours)
                    .WithMany(c => c.RaceHairColours)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("JoinTableRaceHairColour");
                    });
                
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.SkinColours)
                    .WithMany(c => c.RaceSkinColours)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("JoinTableRaceSkinColour");
                    });
                
                modelBuilder.Entity<RaceData>()
                    .HasMany(c => c.Genders)
                    .WithMany(c => c.RaceGenders)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("JoinTableRaceGenders");
                    });
                
                modelBuilder.Entity<AlignmentData>()
                    .HasMany(a => a.AllowedAlignments)
                    .WithMany()
                    .UsingEntity<Dictionary<string, object>>(
                        "JoinTableAllowedAlignments",
                        j => j
                            .HasOne<AlignmentData>()
                            .WithMany()
                            .HasForeignKey("AlignmentDataId"),
                        j => j
                            .HasOne<AlignmentData>()
                            .WithMany()
                            .HasForeignKey("AllowedAlignmentId")
                    );
            }
    }
}
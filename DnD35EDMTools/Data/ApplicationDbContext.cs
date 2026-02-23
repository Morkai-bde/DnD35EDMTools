using System.Text.Json;
using DnD35EDMTools.Data.Classes;
using DnD35EDMTools.Data.Enums;
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
        
        public DbSet<CharacterData> Characters { get; set; }
        public DbSet<CarryingCapacityData> CarryingCapacity { get; set; } 
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
        public DbSet<SkillData> Skills { get; set; } 
        public DbSet<LanguageData> Languages { get; set; }
        public DbSet<CharacterLevel> CharacterLevels { get; set; }
        public DbSet<CharacterLevelSkillRank> CharacterLevelSkillRanks { get; set; }
        public DbSet<CampaignData> Campaigns { get; set; }
        public DbSet<SourceBookData> SourceBooks { get; set; }
        public DbSet<ItemData> Items { get; set; }
        public DbSet<PropertyDefinition> PropertyDefinitions { get; set; }
        public DbSet<ItemProperty> ItemProperties { get; set; }
        public DbSet<CharacterInventoryItem> CharacterInventoryItems { get; set; }
        public DbSet<EquipmentPack> EquipmentPacks { get; set; }
        public DbSet<EquipmentPackItem> EquipmentPackItems { get; set; }
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

                modelBuilder.Entity<RaceData>()
                    .HasMany(r => r.AutomaticLanguages)
                    .WithMany()
                    .UsingEntity(j => j.ToTable("JoinTableRaceAutomaticLanguages"));

                modelBuilder.Entity<RaceData>()
                    .HasMany(r => r.BonusLanguages)
                    .WithMany()
                    .UsingEntity(j => j.ToTable("JoinTableRaceBonusLanguages"));

                modelBuilder.Entity<RaceData>()
                    .Property(r => r.SkillBonuses)
                    .HasConversion(
                        v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                        v => string.IsNullOrWhiteSpace(v) 
                            ? new Dictionary<string, int>()  // Handle empty/null
                            : JsonSerializer.Deserialize<Dictionary<string, int>>(v, (JsonSerializerOptions?)null) 
                              ?? new Dictionary<string, int>()
                    )
                    .HasColumnType("TEXT");
                
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

                modelBuilder.Entity<ClassData>()
                    .HasMany(c => c.ClassSkills)
                    .WithMany(s => s.Classes)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("JoinTableClassSkills");
                    });

                modelBuilder.Entity<ClassData>()
                    .HasMany(c => c.AutomaticLanguages)
                    .WithMany()
                    .UsingEntity(j => j.ToTable("JoinTableClassAutomaticLanguages"));

                modelBuilder.Entity<ClassData>()
                    .HasMany(c => c.BonusLanguages)
                    .WithMany()
                    .UsingEntity(j => j.ToTable("JoinTableClassBonusLanguages"));

                modelBuilder.Entity<CampaignData>()
                    .HasMany(c => c.AllowedSources)
                    .WithMany(s => s.CampaignSourceBooks)
                    .UsingEntity(joinEntity =>
                    {
                        joinEntity.ToTable("JoinTableCampaignSourceBooks");
                    });

                #region Character Levels Configuration

                modelBuilder.Entity<CharacterLevel>()
                    .HasOne(cl => cl.Character)
                    .WithMany()
                    .HasForeignKey(cl => cl.CharacterId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<CharacterLevel>()
                    .HasOne(cl => cl.Class)
                    .WithMany()
                    .HasForeignKey(cl => cl.ClassId)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<CharacterLevel>()
                    .HasIndex(cl => new { cl.CharacterId, cl.Level })
                    .IsUnique();
        
                #endregion

                #region Character Level Skill Ranks Configuration

                modelBuilder.Entity<CharacterLevelSkillRank>()
                    .HasOne(sr => sr.CharacterLevel)
                    .WithMany(cl => cl.SkillRanks)
                    .HasForeignKey(sr => sr.CharacterLevelId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<CharacterLevelSkillRank>()
                    .HasOne(sr => sr.Skill)
                    .WithMany()
                    .HasForeignKey(sr => sr.SkillId)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<CharacterLevelSkillRank>()
                    .HasIndex(sr => new { sr.CharacterLevelId, sr.SkillId })
                    .IsUnique();

                modelBuilder.Entity<CharacterLevelSkillRank>()
                    .ToTable("JoinTableCharacterLevelSkillRanks");
                #endregion

                #region Item System Configuration

                modelBuilder.Entity<ItemData>()
                    .Property(i => i.LootCategories)
                    .HasConversion(
                        v => JsonSerializer.Serialize(v.Select(c => (int)c).ToList(), (JsonSerializerOptions?)null),
                        v => (JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions?)null) ?? new List<int>())
                            .Select(i => (LootCategory)i)
                            .ToList()
                    )
                    .HasColumnType("TEXT");

                modelBuilder.Entity<PropertyDefinition>()
                    .Property(pd => pd.ApplicableItemTypeIds)
                    .HasConversion(
                        v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                        v => (JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions?)null) ?? new List<int>())
                    )
                    .HasColumnType("TEXT");

                modelBuilder.Entity<PropertyDefinition>()
                    .Property(pd => pd.ApplicableItemSubtypeIds)
                    .HasConversion(
                        v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                        v => (JsonSerializer.Deserialize<List<int>>(v, (JsonSerializerOptions?)null) ?? new List<int>())
                    )
                    .HasColumnType("TEXT");

                modelBuilder.Entity<PropertyDefinition>()
                    .HasOne(pd => pd.AppliedToSpecificSkill)
                    .WithMany()
                    .HasForeignKey(pd => pd.AppliedToSpecificSkillId)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<ItemProperty>()
                    .HasOne(ip => ip.Item)
                    .WithMany(i => i.Properties)
                    .HasForeignKey(ip => ip.ItemId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<ItemProperty>()
                    .HasOne(ip => ip.PropertyDefinition)
                    .WithMany()
                    .HasForeignKey(ip => ip.PropertyDefinitionId)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<ItemProperty>()
                    .HasIndex(ip => new { ip.ItemId, ip.PropertyDefinitionId })
                    .IsUnique();

                modelBuilder.Entity<ItemProperty>()
                    .ToTable("JoinTableItemProperties");

                #endregion

                #region Character Inventory Configuration

                modelBuilder.Entity<CharacterInventoryItem>()
                    .HasOne(cii => cii.Character)
                    .WithMany()
                    .HasForeignKey(cii => cii.CharacterId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<CharacterInventoryItem>()
                    .HasOne(cii => cii.Item)
                    .WithMany()
                    .HasForeignKey(cii => cii.ItemId)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<CharacterInventoryItem>()
                    .HasIndex(cii => new { cii.CharacterId, cii.EquippedSlot })
                    .IsUnique()
                    .HasFilter("[EquippedSlot] IS NOT NULL AND [Location] = 'Equipped'");

                modelBuilder.Entity<CharacterInventoryItem>()
                    .ToTable("JoinTableCharacterInventory");

                #endregion

                #region Equipment Packs Configuration

                modelBuilder.Entity<EquipmentPackItem>()
                    .HasOne(epi => epi.Pack)
                    .WithMany(ep => ep.Items)
                    .HasForeignKey(epi => epi.EquipmentPackId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<EquipmentPackItem>()
                    .HasOne(epi => epi.Item)
                    .WithMany()
                    .HasForeignKey(epi => epi.ItemId)
                    .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<EquipmentPackItem>()
                    .ToTable("JoinTableEquipmentPackItems");

                #endregion
            }
    }
}
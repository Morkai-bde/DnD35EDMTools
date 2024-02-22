﻿// <auto-generated />
using System;
using DnD35EDMTools.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240221234810_UpdateColoursToInt")]
    partial class UpdateColoursToInt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("ColourDataRaceData", b =>
                {
                    b.Property<int>("EyeColoursId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RaceEyeColoursId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EyeColoursId", "RaceEyeColoursId");

                    b.HasIndex("RaceEyeColoursId");

                    b.ToTable("RaceEyeColourJoinTable", (string)null);
                });

            modelBuilder.Entity("ColourDataRaceData1", b =>
                {
                    b.Property<int>("HairColoursId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RaceHairColoursId")
                        .HasColumnType("INTEGER");

                    b.HasKey("HairColoursId", "RaceHairColoursId");

                    b.HasIndex("RaceHairColoursId");

                    b.ToTable("RaceHairColourJoinTable", (string)null);
                });

            modelBuilder.Entity("ColourDataRaceData2", b =>
                {
                    b.Property<int>("RaceSkinColoursId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkinColoursId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RaceSkinColoursId", "SkinColoursId");

                    b.HasIndex("SkinColoursId");

                    b.ToTable("RaceSkinColourJoinTable", (string)null);
                });

            modelBuilder.Entity("DnD35EDMTools.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DnD35EDMTools.Data.CharacterData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alignment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diety")
                        .HasColumnType("TEXT");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Eyes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Hair")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Skin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubRace")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DnD35EDMTools.Data.ColourData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ColourHexCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colours");
                });

            modelBuilder.Entity("DnD35EDMTools.Data.FeatsTraitsData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AnimalCompanionRequired")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvatarPointCost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("FeatsTraitsDataId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Page")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("RaceDataId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RequiredAttributes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RequiredClass")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RequiredLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RequiredRaces")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RequiredSkills")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceBook")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FeatsTraitsDataId");

                    b.HasIndex("RaceDataId");

                    b.ToTable("FeatsTraits");
                });

            modelBuilder.Entity("DnD35EDMTools.Data.RaceData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdulthoodAge")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppraiseBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutohypnosisBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BalanceBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BluffBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharismaBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClimbBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConcentrationBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConstitutionBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ControlShapeBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CraftAlchemyBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DecipherScriptBonus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("DexterityBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiplomacyBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisableDeviceBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisguiseBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EscapeArtistBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FeatBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FemaleHeight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FemaleWeight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ForgeryBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FortitudeBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GatherInformationBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HandleAnimalBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HealBonus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HeightDice")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("HideBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HypnosisBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IntelligenceBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IntimidateBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JumpBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeArcanaBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeArchAndEngBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeDungeoneeringBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeGeographyBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeHistoryBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeLocalBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeMonsterLoreBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeNatureBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeNobilityBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgePsionicsBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeRavenloftBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeReligionBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnowledgeThePlanesBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ListenBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaleHeight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaleWeight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MartialLoreBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MiddleAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MiddleAgeDice")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("MoveSilentlyBonus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OldAgeDice")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("OpenLockBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Page")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PsicraftBonus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("ReflexBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RideBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SearchBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenseMotiveBonus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int>("SkillPointBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillPointsPerLevelBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillTricksBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SleightofHandBonus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<int>("SpeakLanguageBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpellcraftBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpotBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StrengthBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurvivalBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SwimBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TumbleBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UseMagicDeviceBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsePsionicDeviceBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UseRopeBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VenerableAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WeightDice")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("WillBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WisdomBonus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("YoungAgeDice")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("DnD35EDMTools.Data.SpellsSLAData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Adapt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApostleofPeace")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Archivist")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Artificer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Assassin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Beguiler")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BelovedofValarian")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Blackguard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Blighter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CastingTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ChampionofGwynharwyn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cleric")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CloisteredCleric")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConcecratedHarrier")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CorruptAvenger")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeathDelver")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeathMaster")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Demonologist")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiscipleofThrym")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DivineCrusader")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DreadNecromancer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Druid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Duskblade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EbonmarInfiltrator")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmissaryofBarachiel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Factotum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fatemaker")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FavoredSoul")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FiendofBlasphemy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Focus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GnomeArtificer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GpCost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Healer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hexblade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hoardstealer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HolyLiberator")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HunteroftheDead")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JusticeofWealdandWoe")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KenderNightstalker")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnightoftheChalice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KnightoftheWeave")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Manipulator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaterialCost")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Mesmerist")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MonsterHunter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MortalHunter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mystic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NightLord")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OcularAdept")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Page")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Paladin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermanencyCost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PiousTemplar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrimeUnderdarkGuide")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RaceDataId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Ranger")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SavingThrow")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Scourge")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShadeHunter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Shair")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Shugenja")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SlayerofDomiel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sorcerer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpellDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SpellLikeDc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpellLikeLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SpellName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpellResistance")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SpellSaveDc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SpellSchool")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SpellfireAdept")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Spellthief")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpiritShaman")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubSchool")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SublimeChord")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuelArcanamach")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TempleRaiderofOlidammara")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UrPriest")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VassalofBahamut")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vigilante")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Warblade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Warlock")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Warmage")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wizard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WuJen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("XpCost")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RaceDataId");

                    b.ToTable("SpellsSla");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ColourDataRaceData", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.ColourData", null)
                        .WithMany()
                        .HasForeignKey("EyeColoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnD35EDMTools.Data.RaceData", null)
                        .WithMany()
                        .HasForeignKey("RaceEyeColoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ColourDataRaceData1", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.ColourData", null)
                        .WithMany()
                        .HasForeignKey("HairColoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnD35EDMTools.Data.RaceData", null)
                        .WithMany()
                        .HasForeignKey("RaceHairColoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ColourDataRaceData2", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.RaceData", null)
                        .WithMany()
                        .HasForeignKey("RaceSkinColoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnD35EDMTools.Data.ColourData", null)
                        .WithMany()
                        .HasForeignKey("SkinColoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DnD35EDMTools.Data.FeatsTraitsData", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.FeatsTraitsData", null)
                        .WithMany("RequiredFeats")
                        .HasForeignKey("FeatsTraitsDataId");

                    b.HasOne("DnD35EDMTools.Data.RaceData", null)
                        .WithMany("RacialFeatureList")
                        .HasForeignKey("RaceDataId");
                });

            modelBuilder.Entity("DnD35EDMTools.Data.SpellsSLAData", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.RaceData", null)
                        .WithMany("SpellLikeAbilities")
                        .HasForeignKey("RaceDataId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnD35EDMTools.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DnD35EDMTools.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DnD35EDMTools.Data.FeatsTraitsData", b =>
                {
                    b.Navigation("RequiredFeats");
                });

            modelBuilder.Entity("DnD35EDMTools.Data.RaceData", b =>
                {
                    b.Navigation("RacialFeatureList");

                    b.Navigation("SpellLikeAbilities");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsMerge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Class = table.Column<string>(type: "TEXT", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: false),
                    SubRace = table.Column<string>(type: "TEXT", nullable: false),
                    Experience = table.Column<string>(type: "TEXT", nullable: false),
                    HitPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    Alignment = table.Column<string>(type: "TEXT", nullable: false),
                    Diety = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Eyes = table.Column<string>(type: "TEXT", nullable: false),
                    Hair = table.Column<string>(type: "TEXT", nullable: false),
                    Skin = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<string>(type: "TEXT", nullable: false),
                    PlayerName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Colour = table.Column<string>(type: "TEXT", nullable: false),
                    ColourHexCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Race = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<string>(type: "TEXT", nullable: false),
                    BaseSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    StrengthBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    DexterityBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    ConstitutionBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    IntelligenceBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    WisdomBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    CharismaBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    AppraiseBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    AutohypnosisBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    BalanceBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    BluffBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    ClimbBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    ControlShapeBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    ConcentrationBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    CraftAlchemyBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    DecipherScriptBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    DiplomacyBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    DisableDeviceBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    DisguiseBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    EscapeArtistBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    ForgeryBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    GatherInformationBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    HandleAnimalBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    HealBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    HideBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    HypnosisBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    IntimidateBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    JumpBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgearcanaBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgearchandengBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgedungeoneeringBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgegeographyBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgehistoryBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgelocalBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgemonsterloreBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgenatureBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgenobilityBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgepsionicsBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgeravenloftBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgereligionBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    KnowledgetheplanesBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    ListenBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    MartialLoreBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    MoveSilentlyBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    OpenLockBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    PsicraftBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    RideBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SearchBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SenseMotiveBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillTricksBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SleightofHandBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SpeakLanguageBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SpellcraftBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SpotBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SurvivalBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SwimBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    TumbleBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    UseMagicDeviceBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    UsePsionicDeviceBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    UseRopeBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    FortitudeBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    ReflexBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    WillBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillPointBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    FeatBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    AdulthoodAge = table.Column<int>(type: "INTEGER", nullable: false),
                    MiddleAge = table.Column<int>(type: "INTEGER", nullable: false),
                    VenerableAge = table.Column<int>(type: "INTEGER", nullable: false),
                    YoungAgeDice = table.Column<int>(type: "INTEGER", nullable: false),
                    MiddleAgeDice = table.Column<int>(type: "INTEGER", nullable: false),
                    OldAgeDice = table.Column<int>(type: "INTEGER", nullable: false),
                    FemaleHight = table.Column<int>(type: "INTEGER", nullable: false),
                    MaleHeight = table.Column<int>(type: "INTEGER", nullable: false),
                    HeightDice = table.Column<string>(type: "TEXT", nullable: false),
                    FemaleWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    MaleWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    WeightDice = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: false),
                    Page = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatsTraits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AvatarPointCost = table.Column<int>(type: "INTEGER", nullable: false),
                    RequiredLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    RequiredClass = table.Column<string>(type: "TEXT", nullable: false),
                    RequiredAttributes = table.Column<string>(type: "TEXT", nullable: false),
                    RequiredRaces = table.Column<string>(type: "TEXT", nullable: false),
                    AnimalCompanionRequired = table.Column<bool>(type: "INTEGER", nullable: false),
                    RequiredSkills = table.Column<string>(type: "TEXT", nullable: false),
                    SourceBook = table.Column<string>(type: "TEXT", nullable: false),
                    Page = table.Column<string>(type: "TEXT", nullable: false),
                    FeatsTraitsDataId = table.Column<int>(type: "INTEGER", nullable: true),
                    RaceDataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatsTraits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatsTraits_FeatsTraits_FeatsTraitsDataId",
                        column: x => x.FeatsTraitsDataId,
                        principalTable: "FeatsTraits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeatsTraits_Races_RaceDataId",
                        column: x => x.RaceDataId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RaceEyeColourJoinTable",
                columns: table => new
                {
                    EyeColoursId = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceEyeColoursId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RaceEyeColourJoinTable_Colours_EyeColoursId",
                        column: x => x.EyeColoursId,
                        principalTable: "Colours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceEyeColourJoinTable_Races_RaceEyeColoursId",
                        column: x => x.RaceEyeColoursId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceHairColourJoinTable",
                columns: table => new
                {
                    HairColoursId = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceHairColoursId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RaceHairColourJoinTable_Colours_HairColoursId",
                        column: x => x.HairColoursId,
                        principalTable: "Colours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceHairColourJoinTable_Races_RaceHairColoursId",
                        column: x => x.RaceHairColoursId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceSkinColourJoinTable",
                columns: table => new
                {
                    RaceSkinColoursId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkinColoursId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RaceSkinColourJoinTable_Colours_SkinColoursId",
                        column: x => x.SkinColoursId,
                        principalTable: "Colours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceSkinColourJoinTable_Races_RaceSkinColoursId",
                        column: x => x.RaceSkinColoursId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellsSla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpellName = table.Column<string>(type: "TEXT", nullable: false),
                    SpellDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Adapt = table.Column<int>(type: "INTEGER", nullable: false),
                    ApostleofPeace = table.Column<int>(type: "INTEGER", nullable: false),
                    Archivist = table.Column<int>(type: "INTEGER", nullable: false),
                    Artificer = table.Column<int>(type: "INTEGER", nullable: false),
                    Assassin = table.Column<int>(type: "INTEGER", nullable: false),
                    Bard = table.Column<int>(type: "INTEGER", nullable: false),
                    Beguiler = table.Column<int>(type: "INTEGER", nullable: false),
                    BelovedofValarian = table.Column<int>(type: "INTEGER", nullable: false),
                    Blackguard = table.Column<int>(type: "INTEGER", nullable: false),
                    Blighter = table.Column<int>(type: "INTEGER", nullable: false),
                    ChampionofGwynharwyn = table.Column<int>(type: "INTEGER", nullable: false),
                    Cleric = table.Column<int>(type: "INTEGER", nullable: false),
                    CloisteredCleric = table.Column<int>(type: "INTEGER", nullable: false),
                    ConcecratedHarrier = table.Column<int>(type: "INTEGER", nullable: false),
                    CorruptAvenger = table.Column<int>(type: "INTEGER", nullable: false),
                    DeathDelver = table.Column<int>(type: "INTEGER", nullable: false),
                    DeathMaster = table.Column<int>(type: "INTEGER", nullable: false),
                    Demonologist = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscipleofThrym = table.Column<int>(type: "INTEGER", nullable: false),
                    DivineCrusader = table.Column<int>(type: "INTEGER", nullable: false),
                    DreadNecromancer = table.Column<int>(type: "INTEGER", nullable: false),
                    Druid = table.Column<int>(type: "INTEGER", nullable: false),
                    Duskblade = table.Column<int>(type: "INTEGER", nullable: false),
                    EbonmarInfiltrator = table.Column<int>(type: "INTEGER", nullable: false),
                    EmissaryofBarachiel = table.Column<int>(type: "INTEGER", nullable: false),
                    Factotum = table.Column<int>(type: "INTEGER", nullable: false),
                    Fatemaker = table.Column<int>(type: "INTEGER", nullable: false),
                    FavoredSoul = table.Column<int>(type: "INTEGER", nullable: false),
                    FiendofBlasphemy = table.Column<int>(type: "INTEGER", nullable: false),
                    GnomeArtificer = table.Column<int>(type: "INTEGER", nullable: false),
                    Healer = table.Column<int>(type: "INTEGER", nullable: false),
                    Hexblade = table.Column<int>(type: "INTEGER", nullable: false),
                    Hoardstealer = table.Column<int>(type: "INTEGER", nullable: false),
                    HolyLiberator = table.Column<int>(type: "INTEGER", nullable: false),
                    HunteroftheDead = table.Column<int>(type: "INTEGER", nullable: false),
                    JusticeofWealdandWoe = table.Column<int>(type: "INTEGER", nullable: false),
                    KenderNightstalker = table.Column<int>(type: "INTEGER", nullable: false),
                    KnightoftheChalice = table.Column<int>(type: "INTEGER", nullable: false),
                    KnightoftheWeave = table.Column<int>(type: "INTEGER", nullable: false),
                    Manipulator = table.Column<int>(type: "INTEGER", nullable: false),
                    Mesmerist = table.Column<int>(type: "INTEGER", nullable: false),
                    MonsterHunter = table.Column<int>(type: "INTEGER", nullable: false),
                    MortalHunter = table.Column<int>(type: "INTEGER", nullable: false),
                    Mystic = table.Column<int>(type: "INTEGER", nullable: false),
                    NightLord = table.Column<int>(type: "INTEGER", nullable: false),
                    OcularAdept = table.Column<int>(type: "INTEGER", nullable: false),
                    Paladin = table.Column<int>(type: "INTEGER", nullable: false),
                    PiousTemplar = table.Column<int>(type: "INTEGER", nullable: false),
                    PrimeUnderdarkGuide = table.Column<int>(type: "INTEGER", nullable: false),
                    Ranger = table.Column<int>(type: "INTEGER", nullable: false),
                    Scourge = table.Column<int>(type: "INTEGER", nullable: false),
                    Shair = table.Column<int>(type: "INTEGER", nullable: false),
                    ShadeHunter = table.Column<int>(type: "INTEGER", nullable: false),
                    Shugenja = table.Column<int>(type: "INTEGER", nullable: false),
                    SlayerofDomiel = table.Column<int>(type: "INTEGER", nullable: false),
                    Sorcerer = table.Column<int>(type: "INTEGER", nullable: false),
                    SpellfireAdept = table.Column<int>(type: "INTEGER", nullable: false),
                    Spellthief = table.Column<int>(type: "INTEGER", nullable: false),
                    SpiritShaman = table.Column<int>(type: "INTEGER", nullable: false),
                    SublimeChord = table.Column<int>(type: "INTEGER", nullable: false),
                    SuelArcanamach = table.Column<int>(type: "INTEGER", nullable: false),
                    TempleRaiderofOlidammara = table.Column<int>(type: "INTEGER", nullable: false),
                    UrPriest = table.Column<int>(type: "INTEGER", nullable: false),
                    VassalofBahamut = table.Column<int>(type: "INTEGER", nullable: false),
                    Vigilante = table.Column<int>(type: "INTEGER", nullable: false),
                    Warlock = table.Column<int>(type: "INTEGER", nullable: false),
                    Warblade = table.Column<int>(type: "INTEGER", nullable: false),
                    Warmage = table.Column<int>(type: "INTEGER", nullable: false),
                    Wizard = table.Column<int>(type: "INTEGER", nullable: false),
                    WuJen = table.Column<int>(type: "INTEGER", nullable: false),
                    SpellSchool = table.Column<string>(type: "TEXT", nullable: false),
                    SubSchool = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    SpellLikeLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    SpellLikeDc = table.Column<int>(type: "INTEGER", nullable: false),
                    SpellSaveDc = table.Column<int>(type: "INTEGER", nullable: false),
                    PermanencyCost = table.Column<int>(type: "INTEGER", nullable: false),
                    XpCost = table.Column<int>(type: "INTEGER", nullable: false),
                    GpCost = table.Column<int>(type: "INTEGER", nullable: false),
                    MaterialCost = table.Column<string>(type: "TEXT", nullable: false),
                    Focus = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    CastingTime = table.Column<string>(type: "TEXT", nullable: false),
                    Range = table.Column<string>(type: "TEXT", nullable: false),
                    SpellResistance = table.Column<string>(type: "TEXT", nullable: false),
                    SavingThrow = table.Column<string>(type: "TEXT", nullable: false),
                    Target = table.Column<string>(type: "TEXT", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: false),
                    Page = table.Column<string>(type: "TEXT", nullable: false),
                    RaceDataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellsSla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellsSla_Races_RaceDataId",
                        column: x => x.RaceDataId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FeatsTraits_FeatsTraitsDataId",
                table: "FeatsTraits",
                column: "FeatsTraitsDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatsTraits_RaceDataId",
                table: "FeatsTraits",
                column: "RaceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceEyeColourJoinTable_EyeColoursId",
                table: "RaceEyeColourJoinTable",
                column: "EyeColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceEyeColourJoinTable_RaceEyeColoursId",
                table: "RaceEyeColourJoinTable",
                column: "RaceEyeColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceHairColourJoinTable_HairColoursId",
                table: "RaceHairColourJoinTable",
                column: "HairColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceHairColourJoinTable_RaceHairColoursId",
                table: "RaceHairColourJoinTable",
                column: "RaceHairColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceSkinColourJoinTable_RaceSkinColoursId",
                table: "RaceSkinColourJoinTable",
                column: "RaceSkinColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceSkinColourJoinTable_SkinColoursId",
                table: "RaceSkinColourJoinTable",
                column: "SkinColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellsSla_RaceDataId",
                table: "SpellsSla",
                column: "RaceDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "FeatsTraits");

            migrationBuilder.DropTable(
                name: "RaceEyeColourJoinTable");

            migrationBuilder.DropTable(
                name: "RaceHairColourJoinTable");

            migrationBuilder.DropTable(
                name: "RaceSkinColourJoinTable");

            migrationBuilder.DropTable(
                name: "SpellsSla");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Colours");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}

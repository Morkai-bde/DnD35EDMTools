using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data;

public class RaceData
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Race { get; set; }
    [MaxLength(10)]
    public string Size { get; set; }
    public int BaseSpeed { get; set; }
    
    public List<GenderData> Genders { get; } = [];
    
    // Racial Ability Bonuses
    public int StrengthBonus { get; set; }
    public int DexterityBonus { get; set; }
    public int ConstitutionBonus { get; set; }
    public int IntelligenceBonus { get; set; }
    public int WisdomBonus { get; set; }
    public int CharismaBonus { get; set; }
    
    // Racial Skill Bonuses
    public int AppraiseBonus { get; set; }
    public int AutohypnosisBonus { get; set; }
    public int BalanceBonus { get; set; }
    public int BluffBonus { get; set; }
    public int ClimbBonus { get; set; }
    public int ControlShapeBonus { get; set; }
    public int ConcentrationBonus { get; set; }
    public int CraftAlchemyBonus { get; set; }
    public int DecipherScriptBonus { get; set; }
    public int DiplomacyBonus { get; set; }
    public int DisableDeviceBonus { get; set; }
    public int DisguiseBonus { get; set; }
    public int EscapeArtistBonus { get; set; }
    public int ForgeryBonus { get; set; }
    public int GatherInformationBonus { get; set; }
    public int HandleAnimalBonus { get; set; }
    public int HealBonus { get; set; }
    public int HideBonus { get; set; }
    public int HypnosisBonus { get; set; }
    public int IntimidateBonus { get; set; }
    public int JumpBonus { get; set; }
    public int KnowledgeArcanaBonus { get; set; }
    public int KnowledgeArchAndEngBonus { get; set; }
    public int KnowledgeDungeoneeringBonus { get; set; }
    public int KnowledgeGeographyBonus { get; set; }
    public int KnowledgeHistoryBonus { get; set; }
    public int KnowledgeLocalBonus { get; set; }
    public int KnowledgeMonsterLoreBonus { get; set; }
    public int KnowledgeNatureBonus { get; set; }
    public int KnowledgeNobilityBonus { get; set; }
    public int KnowledgePsionicsBonus { get; set; }
    public int KnowledgeRavenloftBonus { get; set; }
    public int KnowledgeReligionBonus { get; set; }
    public int KnowledgeThePlanesBonus { get; set; }
    public int ListenBonus { get; set; }
    public int MartialLoreBonus { get; set; }
    public int MoveSilentlyBonus { get; set; }
    public int OpenLockBonus { get; set; }
    public int PsicraftBonus { get; set; }
    public int RideBonus { get; set; }
    public int SearchBonus { get; set; }
    public int SenseMotiveBonus { get; set; }
    public int SkillTricksBonus { get; set; }
    public int SleightofHandBonus { get; set; }
    public int SpeakLanguageBonus { get; set; }
    public int SpellcraftBonus { get; set; }
    public int SpotBonus { get; set; }
    public int SurvivalBonus { get; set; }
    public int SwimBonus { get; set; }
    public int TumbleBonus { get; set; }
    public int UseMagicDeviceBonus { get; set; }
    public int UsePsionicDeviceBonus { get; set; }
    public int UseRopeBonus { get; set; }
    
    // Save bonuses
    public int FortitudeBonus { get; set; }
    public int ReflexBonus { get; set; }
    public int WillBonus { get; set; }
    
    // Human bonuses
    public int SkillPointBonus { get; set; }
    public int SkillPointsPerLevelBonus { get; set; }
    public int FeatBonus { get; set; }
    
    // Spell and Spell Like Ability bonuses
    public List<SpellsSLAData> SpellLikeAbilities { get; set; }
    public List<FeatsTraitsData> RacialFeatureList { get; set; }
    
    // Race Description and information
    public List<ColourData> EyeColours { get; } = [];
    public List<ColourData> HairColours { get; } = [];
    public List<ColourData> SkinColours { get; } = [];
    public int AdulthoodAge { get; set; }
    public int MiddleAge { get; set; }
    public int OldAge { get; set; }
    public int VenerableAge { get; set; }
    public string MaxAge { get; set; }
    [MaxLength(5)]
    public string SimpleDice { get; set; }
    [MaxLength(5)]
    public string ModerateDice { get; set; }
    [MaxLength(5)]
    public string ComplexDice { get; set; }
    public int FemaleHeight { get; set; }
    public int MaleHeight { get; set; }
    [MaxLength(5)]
    public string HeightDice { get; set; }
    public int FemaleWeight { get; set; }
    public int MaleWeight { get; set; }
    [MaxLength(5)]
    public string WeightDice { get; set; }
    // public List<ClassData> FavoredClass { get; set; }
    // public List<LanguagesData> AutomaticLanguages{ get; set}
    // Public List<LanguageData> BonusLanguages { get; set}
    public string? Description { get; set; }
    [MaxLength(64)]
    public string Source { get; set; }
    public int Page { get; set; }
}
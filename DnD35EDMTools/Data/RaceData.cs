namespace DnD35EDMTools.Data;

public partial class RaceData
{
    public int Id { get; set; }
    public string Race { get; set; }
    public string Size { get; set; }
    public int BaseSpeed { get; set; }
    
    // Racial Ability Bonuses
    public int StrengthBonus { get; set; } = 0;
    public int DexterityBonus { get; set; } = 0;
    public int ConstitutionBonus { get; set; } = 0;
    public int IntelligenceBonus { get; set; } = 0;
    public int WisdomBonus { get; set; } = 0;
    public int CharismaBonus { get; set; } = 0;
    
    // Racial Skill Bonuses
    public int AppraiseBonus { get; set; } = 0;
    public int AutohypnosisBonus { get; set; } = 0;
    public int BalanceBonus { get; set; } = 0;
    public int BluffBonus { get; set; } = 0;
    public int ClimbBonus { get; set; } = 0;
    public int ControlShapeBonus { get; set; } = 0;
    public int ConcentrationBonus { get; set; } = 0;
    public int CraftAlchemyBonus { get; set; } = 0;
    public int DecipherScriptBonus { get; set; } = 0;
    public int DiplomacyBonus { get; set; } = 0;
    public int DisableDeviceBonus { get; set; } = 0;
    public int DisguiseBonus { get; set; } = 0;
    public int EscapeArtistBonus { get; set; } = 0;
    public int ForgeryBonus { get; set; } = 0;
    public int GatherInformationBonus { get; set; } = 0;
    public int HandleAnimalBonus { get; set; } = 0;
    public int HealBonus { get; set; } = 0;
    public int HideBonus { get; set; } = 0;
    public int HypnosisBonus { get; set; } = 0;
    public int IntimidateBonus { get; set; } = 0;
    public int JumpBonus { get; set; } = 0;
    public int KnowledgearcanaBonus { get; set; } = 0;
    public int KnowledgearchandengBonus { get; set; } = 0;
    public int KnowledgedungeoneeringBonus { get; set; } = 0;
    public int KnowledgegeographyBonus { get; set; } = 0;
    public int KnowledgehistoryBonus { get; set; } = 0;
    public int KnowledgelocalBonus { get; set; } = 0;
    public int KnowledgemonsterloreBonus { get; set; } = 0;
    public int KnowledgenatureBonus { get; set; } = 0;
    public int KnowledgenobilityBonus { get; set; } = 0;
    public int KnowledgepsionicsBonus { get; set; } = 0;
    public int KnowledgeravenloftBonus { get; set; } = 0;
    public int KnowledgereligionBonus { get; set; } = 0;
    public int KnowledgetheplanesBonus { get; set; } = 0;
    public int ListenBonus { get; set; } = 0;
    public int MartialLoreBonus { get; set; } = 0;
    public int MoveSilentlyBonus { get; set; } = 0;
    public int OpenLockBonus { get; set; } = 0;
    public int PsicraftBonus { get; set; } = 0;
    public int RideBonus { get; set; } = 0;
    public int SearchBonus { get; set; } = 0;
    public int SenseMotiveBonus { get; set; } = 0;
    public int SkillTricksBonus { get; set; } = 0;
    public int SleightofHandBonus { get; set; } = 0;
    public int SpeakLanguageBonus { get; set; } = 0;
    public int SpellcraftBonus { get; set; } = 0;
    public int SpotBonus { get; set; } = 0;
    public int SurvivalBonus { get; set; } = 0;
    public int SwimBonus { get; set; } = 0;
    public int TumbleBonus { get; set; } = 0;
    public int UseMagicDeviceBonus { get; set; } = 0;
    public int UsePsionicDeviceBonus { get; set; } = 0;
    public int UseRopeBonus { get; set; } = 0;
    
    // Save bonuses
    public int FortitudeBonus { get; set; } = 0;
    public int ReflexBonus { get; set; } = 0;
    public int WillBonus { get; set; } = 0;
    
    // Human bonuses
    public int SkillPointBonus { get; set; } = 0;
    public int FeatBonus { get; set; } = 0;
    
    // Spell and Spell Like Ability bonuses
    public List<SpellsSLAData> SpellLikeAbilities { get; set; }
    public List<FeatsTraitsData> RacialFeatureList { get; set; }
    
    // Race Description and information
    public List<ColourData> EyeColours { get; } = [];
    public List<ColourData> HairColours { get; } = [];
    public List<ColourData> SkinColours { get; } = [];
    public int AdulthoodAge { get; set; } = 0;
    public int MiddleAge { get; set; } = 0;
    public int VenerableAge { get; set; } = 0;
    public int YoungAgeDice { get; set; } = 0;
    public int MiddleAgeDice { get; set; } = 0;
    public int OldAgeDice { get; set; } = 0;
    public int FemaleHight { get; set; } = 0;
    public int MaleHeight { get; set; } = 0;
    public string HeightDice { get; set; } = null;
    public int FemaleWeight { get; set; } = 0;
    public int MaleWeight { get; set; } = 0;
    public string WeightDice { get; set; } = null;
    public string Description { get; set; } = null;
    public string Source { get; set; } = null;
    public int Page { get; set; } = 0;
}
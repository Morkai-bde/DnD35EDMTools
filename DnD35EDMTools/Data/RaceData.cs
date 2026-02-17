using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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
    public Dictionary<string, int> SkillBonuses { get; set; } = [];
    
    // Racial Language Bonuses
    public List<LanguageData> AutomaticLanguages { get; set; } = [];
    public List<LanguageData> BonusLanguages { get; set; } = [];
    
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
    public string? Description { get; set; }
    [MaxLength(64)]
    public string Source { get; set; }
    public int Page { get; set; }
}
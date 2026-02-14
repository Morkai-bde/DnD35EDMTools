using DnD35EDMTools.Data.Classes;

namespace DnD35EDMTools.Data;

public class ClassData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string HitDice { get; set; }
    public int SkillPoints { get; set; }
    public List<SkillData> ClassSkills { get; set; }
    public string AgeCategory { get; set; }
    public double FortitudeSavePerLevel { get; set; }
    public double ReflexSavePerLevel { get; set; }
    public double WillSavePerLevel { get; set; }
    public string StartingGold { get; set; }
    public string Description { get; set; }
    public string Source { get; set; }
    public int Page { get; set; }
}

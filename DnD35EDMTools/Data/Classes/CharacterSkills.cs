namespace DnD35EDMTools.Data.Classes;

public class CharacterSkills
{
    public int SkillId { get; set; }
    public string SkillName { get; set; }
    public int Ranks { get; set; }
    public bool IsClassSkill { get; set; }
    public int RankCost => IsClassSkill ? 1 : 2;
}

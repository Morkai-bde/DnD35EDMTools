namespace DnD35EDMTools.Data.Classes;

public class CharacterLevelSkillRank
{
    public int Id { get; set; }
    public int CharacterLevelId { get; set; }
    public int SkillId { get; set; }
    public int RanksPurchased { get; set; }
    public CharacterLevel CharacterLevel { get; set; }
    public SkillData Skill { get; set; }
}

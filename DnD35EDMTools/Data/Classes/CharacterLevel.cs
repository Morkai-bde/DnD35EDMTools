namespace DnD35EDMTools.Data.Classes;

public class CharacterLevel
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public int Level { get; set; }
    public int ClassId { get; set; }
    public int HitPointsRolled { get; set; }
    public DateTime Created { get; set; }
    
    public CharacterData Character { get; set; }
    public ClassData Class { get; set; }
    public List<CharacterLevelSkillRank> SkillRanks { get; set; }
}

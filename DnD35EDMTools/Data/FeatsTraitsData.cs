namespace DnD35EDMTools.Data;

public class FeatsTraitsData
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int AvatarPointCost { get; set; }
    public int RequiredLevel { get; set; }
    public string RequiredClass { get; set; }
    public List<FeatsTraitsData> RequiredFeats { get; set; }
    public List<int> RequiredAttributes { get; set; }
    public List<string> RequiredRaces   { get; set; }
    public bool AnimalCompanionRequired { get; set; }
    public List<int> RequiredSkills { get; set; }
    public string SourceBook { get; set; }
    public string Page { get; set; }
    
}
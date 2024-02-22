namespace DnD35EDMTools.Data;

public class GenderData
{
    public int Id { get; set; }
    public string Gender { get; set; }
    public string Description { get; set; }
    
    public List<RaceData> RaceGenders { get; } = [];
}

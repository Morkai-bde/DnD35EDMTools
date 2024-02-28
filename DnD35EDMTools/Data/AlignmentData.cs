namespace DnD35EDMTools.Data;

public class AlignmentData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public List<AlignmentData> AllowedAlignments { get; set; }
}

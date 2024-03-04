namespace DnD35EDMTools.Data;

public class SourceBookData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Edition { get; set; }
    public string Abbreviation { get; set; }
    public string? Description { get; set; }
    public bool Implemented { get; set; } = false;

    public bool IsSelected { get; set; } = false;
    public List<CampaignData>CampaignSourceBooks { get; set; }
}

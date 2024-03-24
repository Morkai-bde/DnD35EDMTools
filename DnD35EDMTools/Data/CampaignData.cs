namespace DnD35EDMTools.Data;

public class CampaignData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string StatRollingMethod { get; set; }
    public string HitPointRollingMethod { get; set; }
    public bool HideTrainedOnlySkills { get; set; }
    public bool AllowAvatarPoints { get; set; }
    public bool AllowLuck { get; set; }
    public bool AllowWealthAverage { get; set; }
    public bool AllowWealthRandom { get; set; }
    public List<SourceBookData> AllowedSources { get; set; }
}

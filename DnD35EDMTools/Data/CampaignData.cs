namespace DnD35EDMTools.Data;

public class CampaignData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string StatRollingMethod { get; set; }
    public string HitPointRollingMethod { get; set; }
    public bool HideTrainedOnlySkills { get; set; }
    // Custom Content
    public bool AllowAvatarPoints { get; set; }
    public bool AllowLuck { get; set; }
    // Starting Equipment
    public bool AllowWealthAverage { get; set; }
    public bool AllowWealthRandom { get; set; }
    public bool AutoRollWealth { get; set; }
    public bool AllowStartingEquipment { get; set; }
    public bool AllowStartingEquipmentCustomization { get; set; }
    //Source Books and Settings
    public List<SourceBookData> AllowedSources { get; set; }
}

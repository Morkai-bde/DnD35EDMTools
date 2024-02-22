namespace DnD35EDMTools.Data;

public class ColourData
{
    public int Id { get; set; }
    public required string Colour { get; set; }
    public required string ColourHexCode { get; set; } = "";
    
    public List<RaceData> RaceEyeColours { get; } = [];
    public List<RaceData> RaceHairColours { get; } = [];
    public List<RaceData> RaceSkinColours { get; } = [];
}

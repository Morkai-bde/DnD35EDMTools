using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data.Classes;

public class ItemData
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public double Weight { get; set; }
    public int Enchantment { get; set; }
    [MaxLength(20)]
    public string LootCategory { get; set; } = "Mundane";
    [MaxLength(20)]
    public string ItemCategory { get; set; } = "Miscellaneous";
    public double BaseGoldValue { get; set; }
    [MaxLength(100)]
    public string? CraftRequiredFeats { get; set; }
    [MaxLength(50)]
    public string? CraftSkillRequired { get; set; }
    public int CraftDC { get; set; }
    public double CraftGoldCost { get; set; }
    public int CraftCostXp { get; set; }
    [MaxLength(5)]
    public string? SourceBook { get; set; }
    public int? Page { get; set; }
    
    public List<ItemProperty> Properties { get; set; } = [];
}

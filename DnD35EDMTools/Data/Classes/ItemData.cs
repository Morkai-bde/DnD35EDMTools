using System.ComponentModel.DataAnnotations;
using DnD35EDMTools.Data.Enums;

namespace DnD35EDMTools.Data.Classes;

public class ItemData
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public ItemSlot BodySlot { get; set; }
    public double Weight { get; set; }
    public int Enchantment { get; set; }
    public List<LootCategory> LootCategories { get; set; } = [LootCategory.Mundane];
    public ItemType ItemType { get; set; }
    public ItemSubtype? ItemSubtype { get; set; }
    public double BaseGoldValue { get; set; }
    [MaxLength(100)]
    public string? CraftRequiredFeats { get; set; }
    public SkillData? CraftSkillRequired { get; set; }
    public int CraftDC { get; set; }
    public double CraftGoldCost { get; set; }
    public int CraftCostXp { get; set; }
    [MaxLength(5)]
    public string? SourceBook { get; set; }
    public int? Page { get; set; }
    
    public List<ItemProperty> Properties { get; set; } = [];
    public int? CraftSkillRequiredId { get; set; }
}

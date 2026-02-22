using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data.Classes;

public class EquipmentPack
{
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }

    public string? Description { get; set; }
    public double TotalValue { get; set; }

    [MaxLength(5)]
    public string SourceBook { get; set; } = "PHB";
    public int Page { get; set; }

    public List<EquipmentPackItem> Items { get; set; } = [];
}

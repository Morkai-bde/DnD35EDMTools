namespace DnD35EDMTools.Data.Classes;

public class EquipmentPackItem
{
    public int Id { get; set; }
    public int EquipmentPackId { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; } = 1;

    public EquipmentPack Pack { get; set; }
    public ItemData Item { get; set; }
}

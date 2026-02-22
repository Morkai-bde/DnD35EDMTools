using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data.Classes;

public class CharacterInventoryItem
{
    public int Id { get; set; }
    public int CharacterId  { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    [MaxLength(20)]
    public string? Location { get; set; }
    [MaxLength(20)]
    public string? EquippedSlot { get; set; }
    
    public CharacterData Character { get; set; }
    public ItemData Item { get; set; }
}

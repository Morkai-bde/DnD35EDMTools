using DnD35EDMTools.Data.Enums;

namespace DnD35EDMTools.Helpers;

public static class ItemSlotHelper
{
    public static string GetSlotName(ItemSlot slot) => slot switch
    {
        ItemSlot.None => "None",
        ItemSlot.Head => "Head",
        ItemSlot.Face => "Face",
        ItemSlot.Neck => "Neck",
        ItemSlot.Shoulders => "Shoulders",
        ItemSlot.Body => "Body",
        ItemSlot.Torso => "Torso",
        ItemSlot.Waist => "Waist",
        ItemSlot.Wrists => "Wrists",
        ItemSlot.Hands => "Hands",
        ItemSlot.Ring => "Ring",
        ItemSlot.Feet => "Feet",
        ItemSlot.Weapon => "Weapon",
        ItemSlot.Shield => "Shield",
        _ => slot.ToString()
    };
}

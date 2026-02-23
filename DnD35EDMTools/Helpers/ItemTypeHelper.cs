using DnD35EDMTools.Data.Enums;

namespace DnD35EDMTools.Helpers;

public static class ItemTypeHelper
{
    public static string GetDisplayName(ItemType type) => type switch
    {
        ItemType.Ammunition => "Ammunition",
        ItemType.Armour => "Armour",
        ItemType.Clothing => "Clothing",
        ItemType.Container => "Container",
        ItemType.Food => "Food & Drink",
        ItemType.Gear => "Gear",
        ItemType.Miscellaneous => "Miscellaneous",
        ItemType.Potion => "Potions & Oils",
        ItemType.Ring => "Ring",
        ItemType.Rod => "Rod",
        ItemType.Scroll => "Scroll",
        ItemType.Shield => "Shield",
        ItemType.Staff => "Staff",
        ItemType.Tool => "Tool Kit",
        ItemType.TradeGoods => "Trade Goods",
        ItemType.Transport => "Transport",
        ItemType.Wand => "Wand",
        ItemType.Weapon => "Weapon",
        ItemType.WondrousItem => "Wondrous Item",
        _ => type.ToString()
    };

    public static string GetDisplayName(ItemSubtype subtype) => subtype switch
    {
        ItemSubtype.None => "No Subtype",

        ItemSubtype.Arrow => "Arrow",
        ItemSubtype.Bolt => "Bolt",
        ItemSubtype.Bullet => "Bullet",
        ItemSubtype.Needle => "Needle",

        ItemSubtype.LightArmour => "Light",
        ItemSubtype.MediumArmour => "Medium",
        ItemSubtype.HeavyArmour => "Heavy",

        ItemSubtype.Potion => "Potion",
        ItemSubtype.Oil => "Oil",

        ItemSubtype.Arcane => "Arcane",
        ItemSubtype.Divine => "Divine",

        ItemSubtype.Buckler => "Buckler",
        ItemSubtype.LightShield => "Light Shield",
        ItemSubtype.HeavyShield => "Heavy Shield",
        ItemSubtype.TowerShield => "Tower Shield",

        ItemSubtype.SimpleMeleeWeapon => "Simple Melee Weapon",
        ItemSubtype.SimpleRangedWeapon => "Simple Ranged Weapon",
        ItemSubtype.MartialMeleeWeapon => "Martial Melee Weapon",
        ItemSubtype.MartialRangedWeapon => "Martial Ranged Weapon",
        ItemSubtype.ExoticMeleeWeapon => "Exotic Melee Weapon",
        ItemSubtype.ExoticRangedWeapon => "Exotic Ranged Weapon",

        _ => subtype.ToString()
    };

    public static List<ItemSubtype> GetSubtypesForType(ItemType type) => type switch
    {
        ItemType.Ammunition =>
        [
            ItemSubtype.Arrow,
            ItemSubtype.Bolt,
            ItemSubtype.Bullet,
            ItemSubtype.Needle
        ],
        ItemType.Armour =>
        [
            ItemSubtype.LightArmour,
            ItemSubtype.MediumArmour,
            ItemSubtype.HeavyArmour
        ],
        ItemType.Potion =>
        [
            ItemSubtype.Potion,
            ItemSubtype.Oil
        ],
        ItemType.Scroll =>
        [
            ItemSubtype.Arcane,
            ItemSubtype.Divine
        ],
        ItemType.Shield =>
        [
            ItemSubtype.Buckler,
            ItemSubtype.LightShield,
            ItemSubtype.HeavyShield,
            ItemSubtype.TowerShield
        ],
        ItemType.Weapon =>
        [
            ItemSubtype.SimpleMeleeWeapon,
            ItemSubtype.SimpleRangedWeapon,
            ItemSubtype.MartialMeleeWeapon,
            ItemSubtype.MartialRangedWeapon,
            ItemSubtype.ExoticMeleeWeapon,
            ItemSubtype.ExoticRangedWeapon
        ],
        _ => []
    };
}

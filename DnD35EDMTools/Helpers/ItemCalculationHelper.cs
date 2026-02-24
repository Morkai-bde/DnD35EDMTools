using DnD35EDMTools.Data.Classes;
using DnD35EDMTools.Data.Enums;

namespace DnD35EDMTools.Helpers;

public static class ItemCalculationHelper
{
    public static int CalculateTotalEnchantmentBonus(ItemData item)
    {
        return item.Properties.Sum(ip => ip.PropertyDefinition?.EnchantmentCost ?? 0);
    }
    
    public static double CalculateEnchantmentGoldCost(ItemData item)
    {
        var totalBonus = CalculateTotalEnchantmentBonus(item);
        
        var baseCost = item.ItemType switch
        {
            ItemType.Weapon => totalBonus * totalBonus * 2000,
            ItemType.Armour => totalBonus * totalBonus * 1000,
            ItemType.Shield => totalBonus * totalBonus * 1000,
            _ => 0
        };
        
        var additionalCost = item.Properties
            .Sum(ip => ip.PropertyDefinition?.GoldCostMultiplier ?? 0);
        
        return baseCost + additionalCost + item.BaseGoldValue;
    }
    
    public static bool CanAddProperty(ItemData item, PropertyDefinition property)
    {
        var currentTotal = CalculateTotalEnchantmentBonus(item);
        
        if (item.ItemType == ItemType.Weapon || 
            item.ItemType == ItemType.Armour || 
            item.ItemType == ItemType.Shield)
        {
            return currentTotal + property.EnchantmentCost <= 5;
        }
        
        return true;
    }
}
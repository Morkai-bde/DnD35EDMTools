using DnD35EDMTools.Data.Enums;

namespace DnD35EDMTools.Helpers;

public static class PropertyValidationHelper
{
    private static readonly Dictionary<PropertyApplication, string> ValueTypeForApplication = new()
    {
        { PropertyApplication.ArmourClass, "Integer" },
        { PropertyApplication.MaxDexBonus, "Integer" },
        { PropertyApplication.ArmourCheckPenalty, "Integer" },
        { PropertyApplication.ArcaneSpellFailure, "Integer" },
        
        { PropertyApplication.AttackBonus, "Integer" },
        { PropertyApplication.DamageBonus, "Integer" },
        { PropertyApplication.DamageDice, "Dice" },
        { PropertyApplication.CriticalRange, "String" },
        { PropertyApplication.CriticalMultiplier, "String" },
        
        { PropertyApplication.FortitudeSave, "Integer" },
        { PropertyApplication.ReflexSave, "Integer" },
        { PropertyApplication.WillSave, "Integer" },
        
        { PropertyApplication.SkillBonus, "Integer" },
        
        { PropertyApplication.StrengthBonus, "Integer" },
        { PropertyApplication.DexterityBonus, "Integer" },
        { PropertyApplication.ConstitutionBonus, "Integer" },
        { PropertyApplication.IntelligenceBonus, "Integer" },
        { PropertyApplication.WisdomBonus, "Integer" },
        { PropertyApplication.CharismaBonus, "Integer" },
        
        { PropertyApplication.WeaponCategory, "String" },
        { PropertyApplication.WeaponType, "String" },
        { PropertyApplication.DamageType, "String" },
        { PropertyApplication.WeaponRange, "Integer" },
        
        { PropertyApplication.Enhancement, "Integer" },
        { PropertyApplication.Charges, "Integer" },
        { PropertyApplication.SpellLevel, "Integer" }
    };

    private static readonly Dictionary<PropertyApplication, List<ItemType>> ValidItemTypes = new()
    {
        { PropertyApplication.ArmourClass, [ItemType.Armour, ItemType.Shield] },
        { PropertyApplication.MaxDexBonus, [ItemType.Armour, ItemType.Shield] },
        { PropertyApplication.ArcaneSpellFailure, [ItemType.Armour] },
        { PropertyApplication.ArmourCheckPenalty, [ItemType.Armour] },
        
        { PropertyApplication.AttackBonus, [ItemType.Weapon] },
        { PropertyApplication.DamageBonus, [ItemType.Weapon, ItemType.Ammunition] },
        { PropertyApplication.DamageDice, [ItemType.Weapon, ItemType.Ammunition] },
        { PropertyApplication.CriticalRange, [ItemType.Weapon] },
        { PropertyApplication.CriticalMultiplier, [ItemType.Weapon] },
        
        { PropertyApplication.FortitudeSave, [ItemType.Armour, ItemType.WondrousItem] },
        { PropertyApplication.ReflexSave, [ItemType.Armour, ItemType.WondrousItem] },
        { PropertyApplication.WillSave, [ItemType.Armour, ItemType.WondrousItem] },

        { PropertyApplication.SkillBonus, [ItemType.Tool, ItemType.WondrousItem] },

        { PropertyApplication.StrengthBonus, [ItemType.WondrousItem] },
        { PropertyApplication.DexterityBonus, [ItemType.WondrousItem] },
        { PropertyApplication.ConstitutionBonus, [ItemType.WondrousItem] },
        { PropertyApplication.IntelligenceBonus, [ItemType.WondrousItem] },
        { PropertyApplication.WisdomBonus, [ItemType.WondrousItem] },
        { PropertyApplication.CharismaBonus, [ItemType.WondrousItem] },
        
        { PropertyApplication.WeaponCategory, [ItemType.Weapon] },
        { PropertyApplication.WeaponType, [ItemType.Weapon] },
        { PropertyApplication.DamageType, [ItemType.Weapon] },
        { PropertyApplication.WeaponRange, [ItemType.Weapon] },
        
        { PropertyApplication.Enhancement, [ItemType.Weapon, ItemType.Armour, ItemType.Shield] },
        { PropertyApplication.Charges, [ItemType.Wand, ItemType.Staff, ItemType.Rod] },
        { PropertyApplication.SpellLevel, [ItemType.Scroll, ItemType.Potion, ItemType.Wand] }
    };


    public static bool IsValidItemType(PropertyApplication application, ItemType itemType)
    {
        if (!ValidItemTypes.TryGetValue(application, out var validTypes))
            return false;
        
        return validTypes.Contains(itemType);
    }

    public static string GetValueTypeForApplication(PropertyApplication application)
    {
        return ValueTypeForApplication.GetValueOrDefault(application, "String");
    }
    
    public static List<ItemType> GetValidItemTypes(PropertyApplication application)
    {
        return ValidItemTypes.GetValueOrDefault(application, []);
    }
}

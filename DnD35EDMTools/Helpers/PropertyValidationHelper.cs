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
        { PropertyApplication.Enhancement, "Integer" },

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

        { PropertyApplication.WeaponSizeCategory, "String" },
        { PropertyApplication.WeaponType, "String" },
        { PropertyApplication.DamageType, "String" },
        { PropertyApplication.WeaponRange, "Integer" },
        { PropertyApplication.Composite, "Integer" },
        { PropertyApplication.Finesse, "Boolean" },
        { PropertyApplication.Reach, "Boolean" },
        { PropertyApplication.DoubleWeapon, "Boolean" },
        { PropertyApplication.MonkWeapon, "Boolean" },
        { PropertyApplication.Nonlethal, "Boolean" },
        { PropertyApplication.Thrown, "Boolean" },

        { PropertyApplication.Trip, "Boolean" },
        { PropertyApplication.Disarm, "Integer" },
        { PropertyApplication.Sunder, "Integer" },
        { PropertyApplication.Brace, "Boolean" },

        { PropertyApplication.Material, "String" },
        { PropertyApplication.Masterwork, "Boolean" },

        { PropertyApplication.Charges, "Integer" },
        { PropertyApplication.SpellLevel, "Integer" },
        { PropertyApplication.SpeedAdjustment, "Integer" },
        { PropertyApplication.SpeedMultiplier, "Double" }
    };

    private static readonly Dictionary<PropertyApplication, List<ItemType>> ValidItemTypes = new()
    {
        { PropertyApplication.ArmourClass, [ItemType.Armour, ItemType.Shield] },
        { PropertyApplication.MaxDexBonus, [ItemType.Armour, ItemType.Shield] },
        { PropertyApplication.ArcaneSpellFailure, [ItemType.Armour, ItemType.Shield] },
        { PropertyApplication.ArmourCheckPenalty, [ItemType.Armour, ItemType.Shield] },

        { PropertyApplication.AttackBonus, [ItemType.Weapon] },
        { PropertyApplication.DamageBonus, [ItemType.Weapon, ItemType.Ammunition] },
        { PropertyApplication.DamageDice, [ItemType.Weapon, ItemType.Ammunition] },
        { PropertyApplication.CriticalRange, [ItemType.Weapon] },
        { PropertyApplication.CriticalMultiplier, [ItemType.Weapon] },
        { PropertyApplication.Enhancement, [ItemType.Weapon, ItemType.Armour, ItemType.Shield] },

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

        { PropertyApplication.WeaponSizeCategory, [ItemType.Weapon] },
        { PropertyApplication.WeaponType, [ItemType.Weapon] },
        { PropertyApplication.DamageType, [ItemType.Weapon] },
        { PropertyApplication.WeaponRange, [ItemType.Weapon] },
        { PropertyApplication.Composite, [ItemType.Weapon] },
        { PropertyApplication.Finesse, [ItemType.Weapon] },
        { PropertyApplication.Reach, [ItemType.Weapon] },
        { PropertyApplication.DoubleWeapon, [ItemType.Weapon] },
        { PropertyApplication.MonkWeapon, [ItemType.Weapon] },
        { PropertyApplication.Nonlethal, [ItemType.Weapon] },
        { PropertyApplication.Thrown, [ItemType.Weapon] },

        { PropertyApplication.Trip, [ItemType.Weapon] },
        { PropertyApplication.Disarm, [ItemType.Weapon] },
        { PropertyApplication.Sunder, [ItemType.Weapon] },
        { PropertyApplication.Brace, [ItemType.Weapon] },

        { PropertyApplication.Material, [ItemType.Weapon, ItemType.Armour, ItemType.Shield] },
        { PropertyApplication.Masterwork, [ItemType.Weapon, ItemType.Armour, ItemType.Shield] },

        { PropertyApplication.Charges, [ItemType.Wand, ItemType.Staff, ItemType.Rod] },
        { PropertyApplication.SpellLevel, [ItemType.Scroll, ItemType.Potion, ItemType.Wand] },
        { PropertyApplication.SpeedAdjustment, [ItemType.Armour, ItemType.WondrousItem] },
        { PropertyApplication.SpeedMultiplier, [ItemType.Armour, ItemType.WondrousItem] }
    };

    public static string GetValueTypeForApplication(PropertyApplication application)
    {
        return ValueTypeForApplication.GetValueOrDefault(application, "String");
    }

    public static List<ItemType> GetValidItemTypes(PropertyApplication application)
    {
        return ValidItemTypes.GetValueOrDefault(application, []);
    }
}
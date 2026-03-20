namespace DnD35EDMTools.Data.Enums;

public enum PropertyApplication
{
    // Armor/Defense
    ArmourClass = 1,
    MaxDexBonus = 2,
    ArmourCheckPenalty = 3,
    ArcaneSpellFailure = 4,
    
    // Weapon/Attack
    AttackBonus = 11,
    DamageBonus = 12,
    DamageDice = 13,
    CriticalRange = 14,
    CriticalMultiplier = 15,
    
    // Saves
    FortitudeSave = 21,
    ReflexSave = 22,
    WillSave = 23,
    
    // Skills
    SkillBonus = 31,
    
    // Abilities
    StrengthBonus = 41,
    DexterityBonus = 42,
    ConstitutionBonus = 43,
    IntelligenceBonus = 44,
    WisdomBonus = 45,
    CharismaBonus = 46,
    
    // Weapon Properties
    WeaponCategory = 51,
    WeaponType = 52,
    DamageType = 53,
    WeaponRange = 54,
    WeaponHandedness = 55,
    
    // Special
    Enhancement = 61,
    Charges = 62,
    SpellLevel = 63,
    SpeedAdjustment = 64,
    SpeedMultiplier = 65
}

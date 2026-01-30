using System.ComponentModel.DataAnnotations;

namespace DnD35EDMTools.Data;

public class CharacterData
{
    public int Id { get; set; }
    public int CampaignId { get; set; } = 1;
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [MaxLength(100)]
    public int Class { get; set; }
    public int Race { get; set; }
    public int Experience { get; set; }
    public int HitPoints { get; set; }
    [MaxLength(20)]
    public int Order { get; set; }
    public int Morality { get; set; }
    public int? Deity { get; set; }
    public int Age { get; set; }
    public int Gender { get; set; }
    public int Eyes { get; set; }
    public int Hair { get; set; }
    public int Skin { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Wisdom { get; set; }
    public int Intelligence { get; set; }
    public int Charisma { get; set; }
    public List<int> Languages { get; set; } = [1];
    public decimal BaseFortitudeSave { get; set; }
    public decimal BaseReflexSave { get; set; } 
    public decimal BaseWillSave { get; set; }
    public int PlatinumPieces { get; set; }
    public int GoldPieces { get; set; }
    public int SilverPieces { get; set; }
    public int CopperPieces { get; set; }
    public double LightLoad { get; set; }
    public double MediumLoad { get; set; }
    public double HeavyLoad { get; set; }
    public double LiftOverHead { get; set; }
    public double LiftOffGround { get; set; }
    public double PushOrDrag { get; set; }
    [MaxLength(100)]
    public string? PlayerName { get; set; }
    // public int WeightCarried { get; set; }
    // public int MovementSpeed { get; set; }
    // public int Initiative { get; set; }
    // public int ArcaneSpellFailure { get; set; }
    // public int BaseAttackBonus { get; set; }
    // public int SpellResistance { get; set; }
    // public List<int> Saves { get; set; }
    // public List<int> OtherStats { get; set; }
    // public List<string> DamageReductions { get; set; }
    // public List<string> Immunities { get; set; }
    // public List<string> WornArmour { get; set; }
    // public List<int> Armour { get; set; }
    // public List<string> EquippedWeapons { get; set; }
}
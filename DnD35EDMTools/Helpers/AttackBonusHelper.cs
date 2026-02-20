using DnD35EDMTools.Data.Classes;

namespace DnD35EDMTools.Helpers;

public static class AttackBonusHelper
{
    public static int GetTotalBaseAttackBonus(List<CharacterLevel> levels)
    {
        double totalBab = levels.Sum(l => l.Class.BaseAttackBonusPerLevel);
        return (int)Math.Floor(totalBab);
    }
    
    public static List<int> GetAttackBonuses(int baseAttackBonus)
    {
        var attacks = new List<int> { baseAttackBonus };
        
        int currentBonus = baseAttackBonus - 5;
        while (currentBonus > 0)
        {
            attacks.Add(currentBonus);
            currentBonus -= 5;
        }
        
        return attacks;
    }
    
    public static string GetAttackBonusDisplay(int baseAttackBonus)
    {
        var bonuses = GetAttackBonuses(baseAttackBonus);
        return string.Join("/", bonuses.Select(b => $"+{b}"));
    }
}
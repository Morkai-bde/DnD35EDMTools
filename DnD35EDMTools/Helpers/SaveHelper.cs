namespace DnD35EDMTools.Helpers;

public static class SaveHelper
{
    public static double GetBaseSave(double savePerLevel, int abilityScore)
    {
        var baseSave = Math.Abs(savePerLevel - 0.5) < 0.001 ? 2.0 : 0.0;
        var abilityModifier = ConversionHelper.ConvertStatToBonus(abilityScore);
        baseSave += savePerLevel + abilityModifier;
        return Math.Floor(baseSave);
    }
}

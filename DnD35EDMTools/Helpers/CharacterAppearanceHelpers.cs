namespace DnD35EDMTools.Helpers;

public static class CharacterAppearanceHelpers
{
     public static int RandomizeAge(int startingAge, string ageTypeDice)
    {

        var result = startingAge + DiceRoller.RollDice(ageTypeDice);

        return result;
    }

    public static string RandomizeHeight(int baseHeight, string randomHeightDice)
    {
        var result = baseHeight + DiceRoller.RollDice(randomHeightDice);
        
        return ConversionHelper.ConvertInchesToFeetAndInches(result);
    }

    public static int RandomizeWeight(int baseWeight, string randomWeightDice, int characterHeight)
    {
        var randomWeight = DiceRoller.RollDice(randomWeightDice);
        var result = baseWeight + (randomWeight * characterHeight);
        
        return result;
    }
}
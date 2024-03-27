namespace DnD35EDMTools.Helpers;

public static class RandomCharacterHelpers
{
     public static string RandomizeAge(int startingAge, string ageTypeDice)
    {

        var result = startingAge + DiceRoller.RollDice(ageTypeDice);

        return result.ToString();
    }

    public static string RandomizeHeight(int baseHeight, string randomHeightDice)
    {
        var result = baseHeight + DiceRoller.RollDice(randomHeightDice);
        return ConversionHelper.ConvertInchesToFeetAndInches(result);
    }

    // private void RandomizeWeight()
    // {
    //     int baseWeight;
    //     string randomWeightDice = _races.Single(r => r.Id == _selectedRaceId).WeightDice;
    //     int randomWeight = DiceRoller.RollDice(randomWeightDice);
    //     string gender = _genders.Single(g => g.Id == _selectedGenderId).Gender;
    //     if (gender == "Male") baseWeight = _races.Single(r => r.Id == _selectedRaceId).MaleWeight;
    //     else if (gender == "Female") baseWeight = _races.Single(r => r.Id == _selectedRaceId).FemaleWeight;
    //     else baseWeight = (_races.Single(r => r.Id == _selectedGenderId).MaleWeight + _races.Single(r => r.Id == _selectedRaceId).FemaleWeight) / 2;
    //
    //     _characterWeight = baseWeight + (_randomHeight * randomWeight);
    // }
}
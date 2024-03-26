namespace DnD35EDMTools.Helpers;

public static class RandomCharacterHelpers
{
     public static string RandomizeAge(int startingAge, string ageTypeDice)
    {

        var result = startingAge + DiceRoller.RollDice(ageTypeDice);

        return result.ToString();
    }
     
    
    // private void RandomizeHeight()
    // {
    //     int baseHeight;
    //     string randomHeightDice = _races.Single(r => r.Id == _selectedRaceId).HeightDice;
    //     _randomHeight = DiceRoller.RollDice(randomHeightDice);
    //     string gender = _genders.Single(g => g.Id == _selectedGenderId).Gender;
    //     if (gender == "Male") baseHeight = _races.Single(r => r.Id == _selectedRaceId).MaleHeight;
    //     else if (gender == "Female") baseHeight = _races.Single(r => r.Id == _selectedRaceId).FemaleHeight;
    //     else baseHeight = (_races.Single(r => r.Id == _selectedGenderId).MaleHeight + _races.Single(r => r.Id == _selectedRaceId).FemaleHeight) / 2;
    //     
    //     _characterHeight = ConversionHelper.ConvertInchesToFeetAndInches(baseHeight + _randomHeight);
    // }

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
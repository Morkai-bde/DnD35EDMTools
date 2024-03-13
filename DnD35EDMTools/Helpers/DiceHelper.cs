namespace DnD35EDMTools.Helpers;

public static class DiceRoller
{
    private static readonly Random Rand = new Random();

    public static int RollDice(string diceNotation)
    {
        try
        {
            var total = 0;
            var parts = diceNotation.Split(new[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var modifier = 0;
                if (part.Contains('d'))
                {
                    var dicePart = part.Split('d');
                    if (dicePart.Length != 2)
                    {
                        throw new ArgumentException("Invalid dice notation", nameof(diceNotation));
                    }

                    if (!int.TryParse(dicePart[0], out var numberOfDice))
                    {
                        throw new ArgumentException("Invalid number of dice", nameof(diceNotation));
                    }

                    if (!int.TryParse(dicePart[1], out var diceSize))
                    {
                        throw new ArgumentException("Invalid dice size", nameof(diceNotation));
                    }

                    for (var i = 0; i < numberOfDice; i++)
                    {
                        total += Rand.Next(1, diceSize + 1);
                    }
                }
                else
                {
                    if (!int.TryParse(part, out modifier))
                    {
                        throw new ArgumentException("Invalid modifier", nameof(diceNotation));
                    }
                }

                if (part.StartsWith("-"))
                {
                    modifier *= -1;
                }

                total += modifier;
            }

            return total;
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while rolling the dice", ex);
        }
    }
}

public static class RollStats
{
    // 3D6
    private static int ThreeDSix()
    {
        var result = 0;
        try
        {
            for (var i = 0; i < 3; i++)
            {
                int roll = DiceRoller.RollDice("1d6");
                if (roll < 1 || roll > 6)
                {
                    throw new Exception("Invalid dice roll");
                }
                result += roll;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while rolling the dice", ex);
        }
        return result;
    }
    
    // 3D6R1
    public static int ThreeDSixReRollOnes()
    {
        var result = 0;
        try
        {
            for (var i = 0; i < 3; i++)
            {
                int roll;
                do
                {
                    roll = DiceRoller.RollDice("1d6");
                    if (roll < 1 || roll > 6)
                    {
                        throw new Exception("Invalid dice roll");
                    }
                } while (roll == 1);

                result += roll;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while rolling the dice", ex);
        }
        return result;
    }

    // 4D5DL
    public static int FourDSixDropLowest()
    {
        var diceRolls = new List<int>();

        try
        {
            for (var j = 0; j < 4; j++)
            {
                var roll = DiceRoller.RollDice("1d6");
                if (roll < 1 || roll > 6)
                {
                    throw new Exception("Invalid dice roll");
                }
                diceRolls.Add(roll);
            }

            if (diceRolls.Count < 4)
            {
                throw new Exception("Not enough dice rolls");
            }

            var lowestValue = diceRolls.Min();

            diceRolls.Remove(lowestValue);

            var result = diceRolls.Sum();

            return result;
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while rolling the dice", ex);
        }
    }

    public static int RollStatBasedOnMethod(string rollingMethod)
    {
        return rollingMethod switch
        {
            "3D6" => RollStats.ThreeDSix(),
            "3D6R1" => RollStats.ThreeDSixReRollOnes(),
            "4D6DL" => RollStats.FourDSixDropLowest(),
            _ => 8
        };
    }
}

public static class RollHp
{
    // First Level
    public static int LevelOneHitPoints(string hitDice)
    {
        if (string.IsNullOrEmpty(hitDice) || !hitDice.ToUpper().Contains('D'))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        var dIndex = hitDice.ToUpper().IndexOf('D') + 1;
        var diceSizeStr = hitDice.Substring(dIndex);

        if (!int.TryParse(diceSizeStr, out var diceSize))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        return diceSize;
    }
    // REL
    public static int HpEveryLevel(string hitDice)
    {
        if (string.IsNullOrEmpty(hitDice) || !hitDice.Contains('d'))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        return DiceRoller.RollDice(hitDice);
    }
    
    // HP1
    public static int HalfPlusOne(string hitDice)
    {
        if (string.IsNullOrEmpty(hitDice) || !hitDice.Contains('d'))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        var parts = hitDice.Split(new[] { 'd' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2 || !int.TryParse(parts[1], out int diceSize))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        var result = 1 + (int)Math.Round(diceSize / 2.0);
        return result;
    }
    
    // TRD
    public static int TwoThirdsRoundedDown(string hitDice)
    {
        if (string.IsNullOrEmpty(hitDice) || !hitDice.Contains('d'))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        var parts = hitDice.Split(new[] { 'd' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2 || !int.TryParse(parts[1], out int number))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        var result = Math.Floor(number * (2.0 / 3));
        return (int)result;
    }
    
    // QRD
    public static int ThreeQuartersRoundedDown(string hitDice)
    {
        if (string.IsNullOrEmpty(hitDice) || !hitDice.Contains('d'))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        var parts = hitDice.Split(new[] { 'd' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2 || !int.TryParse(parts[1], out int number))
        {
            throw new ArgumentException("Invalid Hit Dice format", nameof(hitDice));
        }

        var result = Math.Floor(number * (3.0 / 4));
        return (int)result;
    }
}
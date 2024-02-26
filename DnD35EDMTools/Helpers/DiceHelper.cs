namespace DnD35EDMTools.Helpers;

public static class DiceRoller
{
    private static readonly Random Rand = new Random();

    public static int RollDice(string diceNotation)
    {
        int total = 0;
        string[] parts = diceNotation.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in parts)
        {
            int modifier = 0;
            if (part.Contains("d"))
            {
                string[] dicePart = part.Split('d');
                int numberOfDice = int.Parse(dicePart[0]);
                int diceSize = int.Parse(dicePart[1]);

                for (int i = 0; i < numberOfDice; i++)
                {
                    total += Rand.Next(1, diceSize + 1);
                }
            }
            else
            {
                modifier = int.Parse(part);
            }

            if (part.StartsWith("-"))
            {
                modifier *= -1;
            }

            total += modifier;
        }

        return total;
    }
}

public static class RollStats
{
    public static int ThreeDSixRerollOnes()
    {
        var result = 0;
        for (int i = 0; i < 3; i++)
        {
            int roll = 0;
            do
            {
                roll = DiceRoller.RollDice("1d6");
            } while (roll == 1);

            result += roll;
        }
        return result;
    }

    public static int FourDSixDropLowest()
    {
        var result = 0;
            var diceRolls = new List<int>();

            for (var j = 0; j < 4; j++)
            {
                var roll = DiceRoller.RollDice("1d6");
                diceRolls.Add(roll);
            }

            var lowestValue = diceRolls.Min();

            diceRolls.Remove(lowestValue);

            result = diceRolls.Sum();

        return result;
    }
}
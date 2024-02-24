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
    public static List<int> ThreeDSix()
    {
        var resultList = new List<int>();
        for (var i = 0; i < 6; i++)
        {
            var result = DiceRoller.RollDice("3d6");
            resultList.Add(result);
        }

        return resultList;
    }
    public static List<int> ThreeDSixRerollOnes()
    {
        var resultList = new List<int>();

        for (var i = 0; i < 6; i++)
        {
            List<int> diceRolls = new List<int>();

            for (var j = 0; j < 3; j++)
            {
                int result = 0;
                do
                {
                    result =DiceRoller.RollDice("1d6");
                } while (result == 1);
                diceRolls.Add(result);
            }

            var sum = diceRolls.Sum();
            resultList.Add(sum);
        }

        return resultList;
    }

    public static List<int> FourDSixDropLowest()
    {
        var resultList = new List<int>();

        for (var i = 0; i < 6; i++)
        {
            List<int> diceRolls = new List<int>();

            for (var j = 0; j < 4; j++)
            {
                var result = DiceRoller.RollDice("1d6");
                diceRolls.Add(result);
            }

            var lowestValue = diceRolls.Min();

            diceRolls.Remove(lowestValue);
            var dropLowestSum = diceRolls.Sum();

            resultList.Add(dropLowestSum);
        }

        return resultList;
    }
}
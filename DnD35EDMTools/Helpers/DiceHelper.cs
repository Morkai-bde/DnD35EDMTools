namespace DnD35EDMTools.Helpers;

public class DiceHelper
{
    public static class DiceRoller
    {
        private static readonly Random Rand = new Random();

        public static int RollDice(int numberOfDice, int diceSize, int modifier = 0)
        {
            var total = 0;

            for (var i = 0; i < numberOfDice; i++)
            {
                total += Rand.Next(1, diceSize + 1);
            }

            total += modifier;

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
                var result = DiceRoller.RollDice(3, 6);
                resultList.Add(result);
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
                    var result = DiceRoller.RollDice(1, 6);
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
}
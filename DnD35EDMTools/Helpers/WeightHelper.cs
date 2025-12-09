using System.Diagnostics;

namespace DnD35EDMTools.Helpers;

public static class WeightHelper
{
    static double GetMultiplier(string size)
    {
        switch (size)
        {
            case "Fine" : return 0.125;
            case "Diminutive" : return 0.25;
            case "Tiny" : return 0.5;
            case "Small" : return 0.75;
            case "Medium" : return 1;
            case "Large" : return 2;
            case "Huge" : return 4;
            case "Gargantuan" : return 8;
            case "Colossal" : return 16;
            default : return 1;
        }
    }
    
    public static int GetWeight(int weight, string size)
    {
        return (int)(weight * GetMultiplier(size));
    }
}

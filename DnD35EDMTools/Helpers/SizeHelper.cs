namespace DnD35EDMTools.Helpers;

public static class SizeHelper
{
    public static int GetSizeAcBonus(string size)
    {
        switch (size)
        {
            case "Fine" : return 8;
            case "Diminutive" : return 4;
            case "Tiny" : return 2;
            case "Small" : return 1;
            case "Medium" : return 0;
            case "Large" : return -1;
            case "Huge" : return -2;
            case "Gargantuan" : return -4;
            case "Colossal" : return -8;
            default : return 0;
        }
    }
}

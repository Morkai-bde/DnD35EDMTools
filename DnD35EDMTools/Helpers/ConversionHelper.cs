namespace DnD35EDMTools.Helpers;

public static class ConversionHelper
{
        public static string ConvertInchesToFeet(decimal heightInInches)
        {
            int feet = (int)(heightInInches / 12);
            int inches = (int)(heightInInches % 12);
            return $"{feet}'{inches}\"";
        }
}

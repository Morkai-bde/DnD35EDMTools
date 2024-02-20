namespace DnD35EDMTools.Helpers;

public static class ConversionHelper
{
    public static int ConvertFeetAndInchesToInches(string feetAndInches)
    {
        // Example input format: "6'1""
        var parts = feetAndInches.Split('\'', '"');
        if (parts.Length != 3)
            throw new ArgumentException("Invalid format. Expected format: feet'inches\"");

        int feet = int.Parse(parts[0]);
        int inches = int.Parse(parts[1]);
        return feet * 12 + inches;
    }

    public static string ConvertInchesToFeetAndInches(int inches)
    {
        int feet = inches / 12;
        int remainingInches = inches % 12;
        return $"{feet}'{remainingInches}\"";
    }

    public static double ConvertFeetAndInchesToCentimeters(string feetAndInches)
    {
        int inches = ConvertFeetAndInchesToInches(feetAndInches);
        return ConvertInchesToCentimeters(inches);
    }

    public static double ConvertInchesToCentimeters(int inches)
    {
        return inches * 2.54;
    }

    public static string ConvertCentimetersToFeetAndInches(double centimeters)
    {
        int inches = Convert.ToInt32(centimeters / 2.54);
        return ConvertInchesToFeetAndInches(inches);
    }

    public static double ConvertCentimetersToInches(double centimeters)
    {
        return centimeters / 2.54;
    }
}

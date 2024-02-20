using DnD35EDMTools.Helpers;

namespace DnD35EDMToolsTests;

public class ConversionHelpersTests
{
    [Fact]
    public void test_ConvertInchesToFeet()
    {
        // Arrange
        
        // Act
        var result = ConversionHelper.ConvertInchesToFeet(73);

        //Assert
        Assert.Equal(@"6'1""", result);
    }
}

using DnD35EDMTools.Helpers;

namespace DnD35EDMToolsTests;

public class Test_DatabaseHelpers
{
    [Fact]
    public void Test_GetOrderNameFromDB()
    {
        // Arrange
        int orderValue = 20;

        // Act
        var result = DatabaseHelper.GetOrderNameFromDB(orderValue);

        // Assert
        Assert.Equal("Chaotic", result);
    }
}

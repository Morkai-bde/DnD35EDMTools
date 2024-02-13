using DnD35EDMTools.Helpers;

namespace DnD35EDMToolsTests;

public class DiceHelperTests
{
    [Fact]
    public void test_DiceRoller()
    {
        // Arrange

        // Act
        var result = DiceHelper.DiceRoller.RollDice(1, 6, 10);
        
        // Assert
        Assert.NotNull(result);
        Assert.InRange(result, 11, 16);
    }

    [Fact]
    public void test_ThreeDSix()
    {
        // Arrange

        // Act

        var resultList = DiceHelper.RollStats.ThreeDSix();

        // Assert
        Assert.NotNull(resultList);
        Assert.Equal(6, resultList.Count);
        Assert.True(resultList.All(x => x is >= 3 and <= 18));
    }

    [Fact]
    public void test_FourDSixDropLowest()
    {
        // Arrange

        // Act

        var resultList = DiceHelper.RollStats.FourDSixDropLowest();

        // Assert
        Assert.NotNull(resultList);
        Assert.Equal(6, resultList.Count);
        Assert.True(resultList.All(x => x is >= 3 and <= 18));
    }
}
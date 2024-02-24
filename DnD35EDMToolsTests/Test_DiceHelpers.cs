using DnD35EDMTools.Helpers;

namespace DnD35EDMToolsTests;

public class DiceHelperTests
{
    [Fact]
    public void test_DiceRoller()
    {
        // Arrange

        // Act
        var result = DiceRoller.RollDice("1d6+10");

        // Assert
        Assert.InRange(result, 11, 16);
    }

    [Fact]
    public void test_DiceRollerAdvanced()
    {
        // Arrange

        // Act
        var result = DiceRoller.RollDice("1d6+10 + 1d6+5");

        // Assert
        Assert.InRange(result, 17, 27);
    }
    
    [Fact]
    public void test_ThreeDSix()
    {
        // Arrange

        // Act

        var resultList = RollStats.ThreeDSix();

        // Assert
        Assert.NotNull(resultList);
        Assert.Equal(6, resultList.Count);
        Assert.True(resultList.All(x => x is >= 3 and <= 18));
    }
    
    [Fact]
    public void test_ThreeDSixRerollOnes()
    {
        // Arrange

        // Act

        var resultList = RollStats.ThreeDSixRerollOnes();

        // Assert
        Assert.NotNull(resultList);
        Assert.Equal(6, resultList.Count);
        Assert.True(resultList.All(x => x is >= 2 and <= 18));
    }

    [Fact]
    public void test_FourDSixDropLowest()
    {
        // Arrange

        // Act

        var resultList = RollStats.FourDSixDropLowest();

        // Assert
        Assert.NotNull(resultList);
        Assert.Equal(6, resultList.Count);
        Assert.True(resultList.All(x => x is >= 2 and <= 18));
    }
}
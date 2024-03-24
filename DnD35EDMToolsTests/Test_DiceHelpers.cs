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
    public void test_ThreeDSixReRollOnes()
    {
        // Arrange

        // Act

        var result = RollStats.ThreeDSixReRollOnes();

        // Assert
        Assert.InRange(result, 3, 18);
    }

    [Fact]
    public void test_FourDSixDropLowest()
    {
        // Arrange

        // Act

        var result = RollStats.FourDSixDropLowest();

        // Assert
        Assert.InRange(result, 3, 18);
    }
    
    [Fact]
    public void test_HPEveryLevel()
    {
        // Arrange
        
        var hitDice = "1d6";
        
        // Act

        var result = RollHp.HpEveryLevel(hitDice);

        // Assert
        Assert.InRange(result, 1, 6);
    }
    
    [Fact]
    public void test_LevelOneHitPoints()
    {
        // Arrange
        
        var hitDice = "1d6";
        
        // Act

        var result = RollHp.LevelOneHitPoints(hitDice);

        // Assert
        Assert.Equal(6, result);
    }
    
    [Fact]
    public void test_HpEveryLevel()
    {
        // Arrange
        
        var hitDice = "1d6";
        
        // Act

        var result = RollHp.HpEveryLevel(hitDice);

        // Assert
        Assert.InRange(result, 1, 6);
    }
    
    [Fact]
    public void test_HalfPlusOne()
    {
        // Arrange
        
        var hitDice = "1d6";
        
        // Act

        var result = RollHp.HalfPlusOne(hitDice);

        // Assert
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void test_TwoThirdsRoundedDown()
    {
        // Arrange
        
        var hitDice = "1d6";
        
        // Act

        var result = RollHp.TwoThirdsRoundedDown(hitDice);

        // Assert
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void test_ThreeQuartersRoundedDown()
    {
        // Arrange
        
        var hitDice = "1d6";
        
        // Act

        var result = RollHp.ThreeQuartersRoundedDown(hitDice);

        // Assert
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void test_StartingWealthRandom()
    {
        // Arrange
        var goldDice = "1d6*10";

        // Act
        var result = RollWealth.StartingWealthRandom(goldDice);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(4, result.Count);
        Assert.Equal(0, result[0]);
        Assert.InRange(result[1], 10, 60);
        Assert.Equal(0, result[2]);
        Assert.Equal(0, result[3]);
    }
    
    [Fact]
    public void test_StartingWealthAverage()
    {
        // Arrange
        var goldDice = "1d6*10";

        // Act
        var result = RollWealth.StartingWealthAverage(goldDice);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(4, result.Count);
        Assert.Equal(0, result[0]);
        Assert.Equal(35, result[1]);
        Assert.Equal(0, result[2]);
        Assert.Equal(0, result[3]);
    }
}
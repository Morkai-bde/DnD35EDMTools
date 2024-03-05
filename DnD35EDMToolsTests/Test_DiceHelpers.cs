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
        
        var HitDice = "1d6";
        
        // Act

        var result = RollHp.HpEveryLevel(HitDice);

        // Assert
        Assert.InRange(result, 1, 6);
    }
    
    [Fact]
    public void test_HpEveryLevel()
    {
        // Arrange
        
        var HitDice = "1d6";
        
        // Act

        var result = RollHp.HpEveryLevel(HitDice);

        // Assert
        Assert.InRange(result, 1, 6);
    }
    
    [Fact]
    public void test_HalfPlusOne()
    {
        // Arrange
        
        var HitDice = "1d6";
        
        // Act

        var result = RollHp.HalfPlusOne(HitDice);

        // Assert
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void test_TwoThirdsRoundedDown()
    {
        // Arrange
        
        var HitDice = "1d6";
        
        // Act

        var result = RollHp.TwoThirdsRoundedDown(HitDice);

        // Assert
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void test_ThreeQuartersRoundedDown()
    {
        // Arrange
        
        var HitDice = "1d6";
        
        // Act

        var result = RollHp.ThreeQuartersRoundedDown(HitDice);

        // Assert
        Assert.Equal(4, result);
    }
}
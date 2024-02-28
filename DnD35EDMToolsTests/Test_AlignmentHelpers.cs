using DnD35EDMTools.Data;
using DnD35EDMTools.Helpers;

namespace DnD35EDMToolsTests;

public class Test_AlignmentHelpers
{
    [Theory]
    [InlineData(20,"Chaotic")]
    [InlineData(50,"Neutral")]
    [InlineData(80,"Lawful")]
    public void Test_GetOrderNameFromDB(int value, string expected)
    {

        var orders = new List<OrderData>()
        {
            new()
            {
                Order = "Chaotic",
                MinValue = 1,
                Midpoint = 20,
                MaxValue = 20,
                Description = "Chaotic"
            },
            new()
            {
                Order = "Neutral",
                MinValue = 41,
                Midpoint = 50,
                MaxValue = 60,
                Description = "Neutral"
            },
            new()
            {
                Order = "Lawful",
                MinValue = 61,
                Midpoint = 80,
                MaxValue = 100,
                Description = "Lawful"
            }
        };

        // Act
        var result = AlignmentHelper.GetOrderNameByValue(orders, value);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(20,"Evil")]
    [InlineData(50,"Neutral")]
    [InlineData(80,"Good")]
    public void Test_GetMoralityNameFromDB(int value, string expected)
    {

        var moralities = new List<MoralityData>()
        {
            new()
            {
                Morality = "Evil",
                MinValue = 1,
                Midpoint = 20,
                MaxValue = 20,
                Description = "Evil"
            },
            new()
            {
                Morality = "Neutral",
                MinValue = 41,
                Midpoint = 50,
                MaxValue = 60,
                Description = "Neutral"
            },
            new()
            {
                Morality = "Good",
                MinValue = 61,
                Midpoint = 80,
                MaxValue = 100,
                Description = "good"
            }
        };

        // Act
        var result = AlignmentHelper.GetMoralityNameByValue(moralities, value);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(20, 20, "Chaotic Evil")]
    [InlineData(50, 50,"True Neutral")]
    [InlineData(80, 80,"Lawful Good")]
    public void GetAlignmentFromOrderAndMorality(int order, int morality, string expected)
    {

        var moralities = new List<MoralityData>()
        {
            new()
            {
                Morality = "Evil",
                MinValue = 1,
                Midpoint = 20,
                MaxValue = 20,
                Description = "Evil"
            },
            new()
            {
                Morality = "Neutral",
                MinValue = 41,
                Midpoint = 50,
                MaxValue = 60,
                Description = "Neutral"
            },
            new()
            {
                Morality = "Good",
                MinValue = 61,
                Midpoint = 80,
                MaxValue = 100,
                Description = "good"
            }
        };
        
        var orders = new List<OrderData>()
        {
            new()
            {
                Order = "Chaotic",
                MinValue = 1,
                Midpoint = 20,
                MaxValue = 20,
                Description = "Chaotic"
            },
            new()
            {
                Order = "Neutral",
                MinValue = 41,
                Midpoint = 50,
                MaxValue = 60,
                Description = "Neutral"
            },
            new()
            {
                Order = "Lawful",
                MinValue = 61,
                Midpoint = 80,
                MaxValue = 100,
                Description = "Lawful"
            }
        };
        
        // Act
        var result = AlignmentHelper.GetAlignmentFromOrderAndMorality(orders, moralities, order, morality);

        // Assert
        Assert.Equal(expected, result);
    }
}
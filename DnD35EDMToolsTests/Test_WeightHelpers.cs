using DnD35EDMTools.Helpers;

namespace DnD35EDMToolsTests;

public class Test_WeightHelpers
{
    [Theory]
    [InlineData(100, "Fine", 12.5)]
    [InlineData(100, "Medium", 100)]
    [InlineData(100, "Colossal", 1600)]

    public void Test_GetWeight(int weight, string size, double expected)
    {
        var result = WeightHelper.GetWeight(weight, size);
        
        Assert.Equal(expected, result);
    }
}

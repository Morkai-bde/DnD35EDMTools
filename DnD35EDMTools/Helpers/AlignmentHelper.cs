using DnD35EDMTools.Data;
namespace DnD35EDMTools.Helpers;

public static class AlignmentHelper
{

    public static string GetOrderNameByValue(List<OrderData> orders, int orderValue)
    {
        var order = orders.FirstOrDefault(o => orderValue >= o.MinValue && orderValue <= o.MaxValue);
        if (order is null)
            throw new InvalidOperationException($"No order found for value {orderValue}.");
        return order.Order;
    }
    
    public static string GetMoralityNameByValue(List<MoralityData> moralities, int moralityValue)
    {
        var morality = moralities.FirstOrDefault(o => moralityValue >= o.MinValue && moralityValue <= o.MaxValue);
        if (morality is null)
            throw new InvalidOperationException($"No morality found for value {moralityValue}.");
        return morality.Morality;
    }

    public static string GetAlignmentFromOrderAndMorality(List<OrderData> orders, List<MoralityData> moralities,
        int orderValue, int moralityValue)
    {
        var order = orders.FirstOrDefault(o => orderValue >= o.MinValue && orderValue <= o.MaxValue);
        var morality = moralities.FirstOrDefault(o => moralityValue >= o.MinValue && moralityValue <= o.MaxValue);
        if (order is null)
            throw new InvalidOperationException($"No order found for value {orderValue}.");
        if (morality is null)
            throw new InvalidOperationException($"No morality found for value {moralityValue}.");
        var alignment = $"{order.Order} {morality.Morality}";
        if (alignment == "Neutral Neutral")
            alignment = "True Neutral";
        return alignment;
    }
}

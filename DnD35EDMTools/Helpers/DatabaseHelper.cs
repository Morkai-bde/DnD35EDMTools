using DnD35EDMTools.Data;
using Microsoft.EntityFrameworkCore;
namespace DnD35EDMTools.Helpers;

public class DatabaseHelper
{
    private List<RaceData> _races = new List<RaceData>();
    // private List<AlignmentData> _alignments = new List<AlignmentData>();
    private static List<OrderData> _orders = new List<OrderData>();
    private List<MoralityData> _moralities = new List<MoralityData>();
    private List<ClassData> _classes = new List<ClassData>();
    private List<GenderData> _genders = new List<GenderData>();
    private List<DeityData> _deities = new List<DeityData>();

    // public static void PopulateOrdersFromDB()
    // {
    //     using var  db = DbContext;
    //     var ordersFromDb = db.Orders.ToList();
    //     _orders.AddRange(ordersFromDb);
    // }

    public static string GetOrderNameFromDB(int orderValue)
    {
        // if (_orders.Count == 0)
        // {
        //         PopulateOrdersFromDB();
        // }
        var orderName = _orders.FirstOrDefault(o => orderValue >= o.MinValue && orderValue <= o.MaxValue);
        return orderName.Order;
    }
    
    public string GetMoralityNameFromDB(int moralityValue)
    {
        var moralityName = _orders.FirstOrDefault(o => moralityValue >= o.MinValue && moralityValue <= o.MaxValue);
        return moralityName.Order;
    }
}

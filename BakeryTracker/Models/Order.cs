using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Price { get; set; }
    public int OrderId { get; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string title, string description, string date, string price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      OrderId = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
    

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int orderId)
    {
      return _instances[orderId - 1];
    }
  }
}
using System.Collections.Generic;
using System;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public int OrderId { get; }
    private static List <Order> _instances = new List<Order> {};
    public Order(string title, string description, string date, int price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      OrderId = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
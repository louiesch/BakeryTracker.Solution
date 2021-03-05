using System.Collections.Generic;
using System;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; }
    // public string Description { get; }
    public Order(string title)
    {
      Title = title;
      // Description = description;
    }
  }
}
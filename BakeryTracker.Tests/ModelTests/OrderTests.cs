using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "March 5th 2021", 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithIdAndGetterReturns_Int()
    {
      string title = "title of order";
      string description = "description of order";
      string date = "order date";
      int price = 5;
      Order newOrder = new Order(title, description, date, price);
      int result = newOrder.OrderId;
      Assert.AreEqual(1, result);
    }

  }
}
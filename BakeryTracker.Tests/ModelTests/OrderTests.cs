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
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    // [TestMethod]
    // public void GetId_OrderInstantiateWithIdAndGetterReturns_Int()
    // {
    //   string title = "title of order";
    //   string description = "description of order";
    //   Order newOrder = new Order(title, description);
    //   string result = newOrder.Title;
    //   Assert.AreEqual(title, result);
    // }

  }
}
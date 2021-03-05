using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "March 5th 2021", "$5");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithIdAndGetterReturns_Int()
    {
      string title = "title of order";
      string description = "description of order";
      string date = "order date";
      string price = "$5";
      Order newOrder = new Order(title, description, date, price);
      int result = newOrder.OrderId;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetOrderProperties_ReturnsOrderDescription_String()
    {
      string title = "title of order";
      string description = "description of order";
      string date = "order date";
      string price = "$5";
      Order newOrder = new Order(title, description, date, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetOrderProperties_ReturnsNewOrderProperties_String()
    {
      string title = "title of order";
      string description = "description of order";
      string date = "order date";
      string price = "$5";
      Order newOrder = new Order(title, description, date, price);
      string updatedDescription = "Wow we've got a new description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title1 = "Catering";
      string title2 = "Mom's Day Bash";
      string description1 = "3 loaves of bread, 10 pastries";
      string description2 = "10 loaves of bread, 20 pastries";
      string date1 = "date1";
      string date2 = "date2";
      string price1 = "$20";
      string price2 = "$50";
      Order newOrder1 = new Order(title1, description1, date1, price1);
      Order newOrder2 = new Order(title2, description2, date2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

  }
}
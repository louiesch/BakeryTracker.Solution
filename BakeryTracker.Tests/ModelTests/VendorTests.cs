using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "test vendor";
      string vendorDescription = "test description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetVendorId_ReturnsVendor_Int()
    {
      string vendorName = "test vendor";
      string vendorDescription = "test description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      int result = newVendor.VendorId;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "Biscuit Bonanaza";
      string vendorName2 = "Louie's Bakery";
      string vendorDescription1 = "100 biscuits";
      string vendorDescription2 = "10 cakes, 4 pastries";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName1 = "Biscuit Bonanaza";
      string vendorName2 = "Louie's Bakery";
      string vendorDescription1 = "100 biscuits";
      string vendorDescription2 = "10 cakes, 4 pastries";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

  }
}
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

  }
}
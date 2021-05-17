using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests 
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new("Test Vendor");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
      Assert.AreEqual("Test Vendor", testVendor.Name);
      Assert.AreEqual(101, testVendor.Id);
      Assert.AreEqual(typeof(List<Order>), testVendor.Orders.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendor_VendorList()
    {
      Vendor vendor1 = new("Vendor1");
      Vendor vendor2 = new("Vendor2");
      List<Vendor> expected = new List<Vendor>{vendor1, vendor2};
      Assert.AreEqual(expected, Vendor.GetAll());
    }

  }
}
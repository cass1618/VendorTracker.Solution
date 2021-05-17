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

  }
}
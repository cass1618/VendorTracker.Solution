using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;

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
      Assert.AreEqual(1, testVendor.Id);
      Assert.AreEqual(typeof(List<Order>), testVendor.Orders.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendor_VendorList()
    {
      Vendor.ClearAll();
      Vendor vendor1 = new("Vendor1");
      Vendor vendor2 = new("Vendor2");
      List<Vendor> expected = new List<Vendor>{vendor1, vendor2};
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    [TestMethod]
    public void GetById_ReturnsVendorWithGivenId_Vendor()
    {
      Vendor.ClearAll();
      Vendor vendor1 = new("Vendor1");
      Vendor vendor2 = new("Vendor2");
      Assert.AreEqual(vendor2, Vendor.GetById(2));
    }

    [TestMethod]
    public void AddOrder_CreatesOrderAndAddsToOrderList_VendorList()
    {
      Vendor.ClearAll();
      Vendor testVendor = new("Test Vendor");
      Order testOrder = new("Test Order", "Test order description", 50, 1, 1);
      testVendor.AddOrder("Test Order","Test order description",50, 1, 1);
      List<Order> expected = new List<Order>{testOrder};
      Assert.AreEqual(expected[0].GetType(), testVendor.Orders[0].GetType());
      Assert.AreEqual(expected[0].Title, testVendor.Orders[0].Title);
    }
  }
}
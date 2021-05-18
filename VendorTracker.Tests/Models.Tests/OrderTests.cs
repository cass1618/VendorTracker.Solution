using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new("Test Order", "test order", 45.95, 1, 1);
      DateTime expected = new DateTime(2021, 1, 1);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
      Assert.AreEqual("Test Order", testOrder.Title);
      Assert.AreEqual("test order", testOrder.Description);
      Assert.AreEqual(45.95, testOrder.Cost);
      Assert.AreEqual(1, testOrder.Id);
      Assert.AreEqual(DateTime.Now.ToString(), testOrder.DateOrdered.ToString());
      Assert.AreEqual(expected, testOrder.DeliveryDate);
    }

    [TestMethod]
    public void GetById_ReturnsOrderWithGivenId_Order()
    {
      Order.ClearAll();
      Order order1 = new("Order1", "description", 10, 1, 1);
      Order order2 = new("Order2", "description", 20, 2, 2);
      Assert.AreEqual(order2.Title, Order.GetById(2).Title);
    }
  }
}
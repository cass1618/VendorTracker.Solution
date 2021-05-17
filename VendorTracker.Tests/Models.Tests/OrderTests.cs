using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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

  }
}
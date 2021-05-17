using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.GetById(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Console.WriteLine("orderId "+orderId);
      Console.WriteLine("orders by vendor: "+Vendor.GetById(1).Orders[0].Title);
      Vendor vendor = Vendor.GetById(vendorId);
      Order order = vendor.Orders[orderId-1];
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}
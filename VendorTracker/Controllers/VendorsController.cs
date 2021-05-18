using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name)
    {
      Vendor newVendor = new(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.GetById(id);
      List<Order> VendorItems = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", VendorItems);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, double cost, int month, int day)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.GetById(vendorId);
      vendor.AddOrder(title, description, cost, month, day);
      List<Order> orders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", orders);
      return View("Show", model);
    }
  }
}
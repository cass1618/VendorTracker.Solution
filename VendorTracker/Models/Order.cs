using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Cost { get; set; }
    public DateTime DateOrdered { get; }
    public DateTime DeliveryDate { get; set; }
    private static List<Order> _orderList = new List<Order>{};
    public int Id { get; }

    public Order(string title, string description, double cost, int month, int day)
    {
      Title = title;
      Description = description;
      Cost = cost;
      DateOrdered = DateTime.Now;
      DeliveryDate = new DateTime(2021, month, day);
      Id = _orderList.Count;
    }
  }
}
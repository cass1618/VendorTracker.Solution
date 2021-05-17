using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static List<Vendor> _vendorList = new List<Vendor>{};

    public Vendor(string name)
    {
      Name = name;
      Orders = new List<Order>{};
      Id = _vendorList.Count + 101;
    }
  }
}
using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorInstances = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _vendorInstances.Add(this);
      Orders = new List<Order>{};
    }
  }
}
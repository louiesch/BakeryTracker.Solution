using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/vendors/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

  }
}
using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, string date, string price)
    {
      Order myOrder = new Order(title, description, date, price);
      return RedirectToAction("Index");
    }

  }
}
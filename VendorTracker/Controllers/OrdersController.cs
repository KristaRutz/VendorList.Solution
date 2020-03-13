using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Index()
    {
      return View(Order.GetAll());
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      return View(Vendor.Find(vendorId));
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      Order currentOrder = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>
      {
        {"vendor", currentVendor},
        {"order", currentOrder}
      };
      return View(model);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpPost("vendors/{vendorId}/orders/{orderId}/delete")]
    public ActionResult Delete(int orderId)
    {
      Order currentOrder = Order.Find(orderId);
      currentOrder.Destroy();
      return RedirectToAction("Index");
    }
  }
}
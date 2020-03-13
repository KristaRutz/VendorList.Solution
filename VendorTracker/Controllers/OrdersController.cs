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
      return RedirectToAction("Show", "Vendors");
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      return View(Vendor.Find(vendorId));
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show()
    {
      return View();
    }
  }
}
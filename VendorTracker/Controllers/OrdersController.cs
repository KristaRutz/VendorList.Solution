using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/0/items")]
    public ActionResult Index()
    {
      return RedirectToAction("Show", "Vendors");
    }

    [HttpGet("/vendors/0/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/0/items/0")]
    public ActionResult Show()
    {
      return View();
    }
  }
}
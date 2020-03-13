using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("My Example Cafe", "cafe");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "My Example Cafe";
      string description = "cafe";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "My Example Cafe";
      string description = "cafe";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(description, newVendor.Description);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "My Example Cafe";
      string description = "cafe";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(1, newVendor.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("Epicodus, Inc.", "school");
      Vendor newVendor2 = new Vendor("Walnut Street Coffee", "cafe");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      CollectionAssert.AreEqual(newList, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("Epicodus, Inc.", "school");
      Vendor newVendor2 = new Vendor("Walnut Street Coffee", "cafe");
      Assert.AreEqual(newVendor2, Vendor.Find(2));
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Vendor newVendor = new Vendor("Epicodus, Inc.", "school");
      Order newOrder = new Order(5, 3);
      newVendor.AddOrder(newOrder);

      List<Order> newList = new List<Order> { newOrder };

      CollectionAssert.AreEqual(newList, newVendor.Orders);
    }
  }
}
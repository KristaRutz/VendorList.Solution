using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(1, 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetBread_ReturnsBread_Int()
    {
      Order newOrder = new Order(1, 0);
      Assert.AreEqual(1, newOrder.Bread);
    }

    [TestMethod]
    public void GetPastries_ReturnsPastries_Int()
    {
      Order newOrder = new Order(0, 1);
      Assert.AreEqual(1, newOrder.Pastries);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Bread: 1, Pastries: 1";
      Order newOrder = new Order(1, 1);
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      CollectionAssert.AreEqual(newList, Order.GetAll());
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      Order newOrder1 = new Order(1, 1);
      Order newOrder2 = new Order(2, 2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      CollectionAssert.AreEqual(newList, Order.GetAll());
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      Order newOrder = new Order(1, 1);
      Assert.AreEqual(1, newOrder.Id);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder1 = new Order(1, 1);
      Order newOrder2 = new Order(2, 2);
      Assert.AreEqual(newOrder2, Order.Find(2));
    }

  }
}
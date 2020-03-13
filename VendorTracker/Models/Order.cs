using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Description { get; set; }

    public string Notes { get; set; }
    public int Id { get; }
    public static int RunningCount { get; set; } = 0;
    public int Bread { get; set; }
    public int Pastries { get; set; }
    public DateTime DateOrdered { get; }
    public DateTime DateModified { get; set; }
    public DateTime DateDue { get; set; }
    public string Title { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(int bread, int pastries)
    {
      Bread = bread;
      Pastries = pastries;
      Notes = "none";
      _instances.Add(this);
      RunningCount++;
      Id = RunningCount;
      DateOrdered = DateTime.Now;
      DateModified = DateOrdered;
      DateDue = DateModified.AddDays(2);
      Title = $"Order No. {Id}, {DateModified.ToString()}";
      Description = $"Bread: {Bread}, Pastries: {Pastries}";
    }

    public Order(int bread, int pastries, string notes)
    {
      Bread = bread;
      Pastries = pastries;
      Notes = notes;
      _instances.Add(this);
      RunningCount++;
      Id = RunningCount;
      DateOrdered = DateTime.Now;
      DateModified = DateOrdered;
      DateDue = DateModified.AddDays(2);
      Title = $"Order No. {Id}, {DateModified.ToString()}";
      Description = $"Bread: {Bread}, Pastries: {Pastries}";
    }

    public int GetPrice()
    {
      return (Bread * 5) + (Pastries * 2);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
      RunningCount = 0;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
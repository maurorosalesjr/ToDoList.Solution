using System.Collections.Generic;
using System;

namespace ToDoList.Models

{
  public class Item
  {
    public string Description { get; set; }
    public int UniqueId { get; set; }

    private static List<Item> _instances = new List<Item> {};

    public static List<Item> GetAll()
      {
        return _instances;
      }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static int ID = 1;
    public static int CountItems()
    {
      return ID++;
    }
    
    public Item(string description)
    {
      Description = description;

      UniqueId = CountItems();
      _instances.Add(this);
    }

    


  }
}
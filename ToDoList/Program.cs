using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {

      
      Console.WriteLine("Would you like to add an item to your To-Do List? ['Y' for yes, 'Enter' for no]");
      string answer = Console.ReadLine();

      
      if (answer == "Y" || answer == "y")
      {
          Console.WriteLine("Enter your to-do item: ");
          Item item = new Item(Console.ReadLine());
          Console.WriteLine(item.Description + " has been added to your To-Do List!");
          
              
          Main();
      } 
      else 
      { 
      
        Console.WriteLine("Do you want to view your list so far or exit the program? ['Y' for view or 'Enter' for exiting]");
        string viewOrExit = Console.ReadLine();
        if (viewOrExit == "Y" || viewOrExit == "y")
        { 
          List<Item> result = Item.GetAll();
          
            Console.WriteLine("Your to do list:");
          foreach (Item thisItem in result)
          {
            Console.WriteLine(thisItem.UniqueId + ": " + thisItem.Description);
          }

          Main();
        }
        else
        {
          Console.WriteLine("Goodbye!");
        }
      }


    }
  }
}
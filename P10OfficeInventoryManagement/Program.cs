using System;
using System.Collections.Generic;

public class InventoryManagement
{
  public static void Main(string[] args){
    
    List<string> inventoryList = new List<string>();
    inventoryList.AddRange(new string[] {"Printer", "Laptop", "Desk Chair", "Monitor", "keyboard"});
    Console.WriteLine(inventoryList.Count);
    
    bool hasDeskChair = inventoryList.Contains("Desk Chair");
    Console.WriteLine(hasDeskChair);

    bool removed = inventoryList.Remove("Printer");
    Console.WriteLine(removed);

    foreach(string item in inventoryList)
    {
      Console.WriteLine(item);
    }

    List<string> newItems = new List<string>{"Mouse", "Desk Lamp"};
    inventoryList.AddRange(newItems);

    //The two items we just received were mistakenly delivered and need to be returned.
    Console.WriteLine("");
    inventoryList.RemoveRange(4,2);

    List<string> topInventory = inventoryList.GetRange(0,3);

    foreach(string item in topInventory)
    {
      Console.WriteLine(item);
    }


  }
}
using System;

namespace SpaceMission
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceInventory = new string[] {"Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools"};

      int[] itemQuantities = new int[] {10, 8, 15, 5, 6, 9, 4, 7};

      if (spaceInventory.Length == 8){
        Console.WriteLine("Space Inventory is ready to go!");
      }
      else if (spaceInventory.Length > 8){
        Console.WriteLine("Too many items!");
      }
      else{
        Console.WriteLine("Add more items!");
      }
      Console.WriteLine($"{spaceInventory[1]} {itemQuantities[1]}");

      spaceInventory[spaceInventory.Length - 1] = "Scientific Instruments";
      itemQuantities [itemQuantities .Length - 1] = 5;

      int First5Quantity = Array.IndexOf(itemQuantities, 5);

      Console.WriteLine($"The first item with quantity 5 is at position {First5Quantity}.");

      Array.Reverse(spaceInventory);
      Console.WriteLine(spaceInventory[0]);
      Console.WriteLine(spaceInventory[spaceInventory.Length - 1]);

      Array.Sort(spaceInventory);
      Console.WriteLine(spaceInventory[0]);
      Console.WriteLine(spaceInventory[spaceInventory.Length - 1]);
    }
  }
}
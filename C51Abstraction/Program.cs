using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Martre";
      f.biome = "Mountain";
      f.trees = 1600;
      f.age = 35;

      Console.WriteLine(f.name);
    }
  }
}

using System;

namespace Constructors
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Forest f = new Forest("Congo","Tropical");
      
      Console.WriteLine(f.name);
      Console.WriteLine(f.biome);
      
    }
  }
}

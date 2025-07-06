using System;

namespace OverloadingConstructors
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");

      Forest f1 = new Forest("Rendlesham");
      
      Console.WriteLine(f1.biome);
    }
  }
}

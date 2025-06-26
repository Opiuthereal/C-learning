using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Jupiter"));
    }

    static string DecoratePlanet(string planetName){
      return $"*.*.* Welcome to {planetName} *.*.*";
    }
    
	}
}

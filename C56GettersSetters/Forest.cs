using System;

namespace Properties
{
  public class Forest
  {
    private string name;
    public int trees;
    public int age;
    private string biome;

    public string Biome{
      get {return biome;}
      set 
      {
        if (value == "Tropical" || value == "Temperate" || value == "Boreal") { biome = value;}
        else {biome = "Unknown";}
      }
    }

    public string Name
    {
      get {return name;}
      set {name = value;}
    }
  }

}

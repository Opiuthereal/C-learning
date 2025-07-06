using System;

namespace AutoImplementedProperties
{
  class Forest
  {
    /* equivalent to
    private string name;
    public string Name
    {
      get 
      {what should be inside}

      set
      {what should be inside}
    }*/
    public string Name
    { get; set; }

    public int Trees
    {get; set;}

    public int age;

    private string biome;
    public string Biome 
    {
      get {
        return biome;
      }
      set {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0) {
          biome = value;
        }
        else {
          biome = "Unknown";
        }
      }
    }
  }

}
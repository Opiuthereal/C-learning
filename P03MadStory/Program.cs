using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is for your entertainement
      Author: Opiuthereal
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Let's create a story:");

      // Give the Mad Lib a title:
      string title = "What a Wonderful day !";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("\nEnter the hero name: ");
      string name = Console.ReadLine();

      Console.WriteLine("\nEnter the first adjective of the story:");
      string adjective1 = Console.ReadLine();

      Console.WriteLine("\nThe second one:");string adjective2 = Console.ReadLine();


      Console.WriteLine("\nAnd the third one:");
      string adjective3 = Console.ReadLine();

      Console.WriteLine("\nNow enter a verb:");
      string verb = Console.ReadLine();

      Console.WriteLine("\nFirst noun:");
      string noun1 = Console.ReadLine();

      Console.WriteLine("\nSecond noun:");
      string noun2 = Console.ReadLine(); 

      Console.WriteLine("\nNow I need some special words:");
      Console.WriteLine("An animal:");
      string animal = Console.ReadLine();

      Console.WriteLine("\nA food:");
      string food = Console.ReadLine();

      Console.WriteLine("\nA fruit:");
      string fruit = Console.ReadLine();

      Console.WriteLine("\nA superhero:");
      string superhero = Console.ReadLine();

      Console.WriteLine("\nA country:");
      string country = Console.ReadLine();

      Console.WriteLine("\nA dessert:");
      string dessert = Console.ReadLine();

      Console.WriteLine("\nA year:");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

      // Print the story:
      Console.WriteLine(story);
    }
  }
}
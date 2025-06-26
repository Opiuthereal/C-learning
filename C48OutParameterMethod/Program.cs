using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string scoreAsString = "85.6";
      double scoreAsDouble;
      bool outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

      Console.WriteLine($"{outcome}{scoreAsDouble}");
      
      bool marker;
      string whisper = Whisper("IS IT WORKING ?", out marker);
      Console.WriteLine(whisper);
    }

    static string Whisper(string statement, out bool marker){
      marker = true;
      return statement.ToLower();

    }

    
	}
}
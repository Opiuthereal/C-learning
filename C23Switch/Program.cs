using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      double ph = 14;

      switch (ph){
        case <= 3:
            Console.WriteLine("Very Acidic");
            break;

        case double n when n < 7 && n > 3:
            Console.WriteLine("Acidic");
            break;

        case >= 11:
            Console.WriteLine("Very Basic");
            break;

        case double n when n > 7 && n < 11:
            Console.WriteLine("Basic");
            break;

        default:
            Console.WriteLine("Neutral");
            break;
      }
    }
  }
}

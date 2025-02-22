using System;

namespace EqualityOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      int cookiesSoldGuess = 250;
      int storeOneCookies = 110;
      int storeTwoCookies = 135;

      int cookiesSoldActual = storeOneCookies + storeTwoCookies;

      bool guessedCorrect = (cookiesSoldActual == cookiesSoldGuess);

      Console.WriteLine(guessedCorrect);
    }
  }
}
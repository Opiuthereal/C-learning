using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("How much cents do you want to change ?");

      double startCoin = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine(startCoin + " cents is equal to ...");

      double goldCoin = 10;
      double silverCoin = 5;

      double goldCoinUsed = Math.Floor(startCoin / goldCoin);
      double remainingCents = startCoin % goldCoin;

      double silverCoinUsed = Math.Floor(startCoin / silverCoin);
      remainingCents = remainingCents % silverCoin;

      Console.WriteLine("Gold coins: " + goldCoinUsed + "\nSilver coins: " + silverCoinUsed + "\nBronze coins: " + Math.Floor(remainingCents));
    }
  }
}
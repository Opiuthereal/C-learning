﻿using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare steps variable
      int steps = 0;

      // Two steps forward 
      steps = steps + 2;

      // One step back 
      steps = steps - 1;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}
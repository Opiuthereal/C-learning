﻿using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>();

      marathons.Add(144.07);
      marathons.Add(143.12);

      Console.WriteLine(marathons[1]);
    }
  }
}
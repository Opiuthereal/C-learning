using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      List<double> topMarathons = marathons.GetRange(0,3);
      
      foreach(double time in topMarathons)
      {
        Console.WriteLine(time);
      }

      Console.WriteLine("");

      topMarathons.AddRange(new double[] { 122.45, 167.88});
      topMarathons.InsertRange(2, new double[] {120.06, 134.76});
      topMarathons.RemoveRange(4, 2);
      foreach(double time in topMarathons)
      {
        Console.WriteLine(time);
      }
    }
  }
}
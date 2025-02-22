using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      /*You are driving to your family’s house for a holiday and want to see if you’ll get there before dinner. Dinner will begin at 6:00 PM, and the house is 95 miles away. If you leave at 2:00PM and drive an average of 30 miles per hour, will you get there early (before 6:00pm)?*/

      double timeToDinner = 4;
      double distance = 95;
      double rate = 30;

      double tripDuration = distance / rate;
      bool answer = tripDuration <= timeToDinner;

      Console.WriteLine(answer);

    }
  }
}
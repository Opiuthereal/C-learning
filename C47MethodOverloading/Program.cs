using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      IntroduceFriends("Laika", "Albert");
      IntroduceFriends("Naomi", "Jasmine", "Cyrus");
      IntroduceFriends();
    }
    static void IntroduceFriends(string friend1, string friend2){
      Console.WriteLine($"These are my friends, {friend1} and {friend2}!");
    }

    static void IntroduceFriends(string friend1, string friend2, string friend3){
      Console.WriteLine($"These are my friends, {friend1}, {friend2}, and {friend3}!");
    }

    static void IntroduceFriends(){
      Console.WriteLine("There is no one who needs to be introduced.");
    }

  }
}

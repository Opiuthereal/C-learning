using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time, ";
      string middle = "there was a knight. ";
      string end = "He embarked on a journey to save the princess...";

      // Concatenate the string and the variables
      string story = beginning + middle + end;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}
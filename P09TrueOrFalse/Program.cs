using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'");

      string[] questions = new string[] {"Human usually like pizza.","cats are animals.", "1 + 5 = 7."};
      bool[] answers = new bool[] {true, true, false};
      bool[] responses = new bool[answers.Length];
      int askingIndex = 0;

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning: too much or not enough answers to your questions.");
      }

      foreach (string elem in questions)
      {
        bool isBool = false;
        while(!isBool)
        {
          Console.WriteLine($"\n{askingIndex+1}. {elem}\ntrue or false ?");
          string input = Console.ReadLine().ToLower();
          if (input == "true" || input == "false")
          {
            bool inputBool;
            bool.TryParse(input, out inputBool);
            responses[askingIndex] = inputBool;
            isBool = true;
            askingIndex++;
          }
        }
      }

      int scoringIndex = 0;
      int score = 0;
      foreach (bool elem in answers)
      {
        bool corresponAnswer = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex+1}. Input: {corresponAnswer} | Answer: {elem}");
        if (corresponAnswer == elem)
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
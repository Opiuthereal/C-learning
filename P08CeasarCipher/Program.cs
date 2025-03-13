using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      char current = 'c';
      int position = 3;
      char newChar = 'f';

      Console.WriteLine("Enter the prompt to cipher with the Ceasar technic:");
      string message = Console.ReadLine();

      char[] secretMessage = message.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++)
      {
        current = secretMessage[i];
        position = Array.IndexOf(alphabet, current);
        position= (position + 3) % 26;
        newChar = alphabet[position];
        encryptedMessage[i] = newChar;
      }

      Console.WriteLine(String.Join("",encryptedMessage));

    }
  }
}
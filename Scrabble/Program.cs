using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to see it's scrabble score: ");
      Score userScore = new Score();
      string userWord = Console.ReadLine();
      Console.WriteLine(userScore.GetScore(userWord));
      Main();
    }
  }
}
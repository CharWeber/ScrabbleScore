using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Score
  {
    public static Dictionary<string, int> scrabbleScores = new Dictionary<string, int>() {
      {"A", 1},
      {"B", 3},
      {"C", 3},
      {"D", 2},
      {"E", 1},
      {"F", 4},
      {"G", 2},
      {"H", 4},
      {"I", 1},
      {"J", 8},
      {"K", 5},
      {"L", 1},
      {"M", 3},
      {"N", 1},
      {"O", 1},
      {"P", 3},
      {"Q", 10},
      {"R", 1},
      {"S", 1},
      {"T", 1},
      {"U", 1},
      {"V", 4},
      {"W", 4},
      {"X", 8},
      {"Y", 4},
      {"Z", 10}
    };

    public int GetScore(string word)
    { 
      string upperWord = word.ToUpper();
      int wordScore = 0;
      for (int i = 0; i < upperWord.Length; i++)
      {
        string letter = upperWord[i].ToString();
        wordScore += scrabbleScores[letter];
      }
      return wordScore;
    }
  }
}
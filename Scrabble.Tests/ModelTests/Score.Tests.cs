using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void Score_CreatesInstanceOfScore_Int()
    {
    Score testScore = new Score();
    Assert.AreEqual(typeof(Score), testScore.GetType());
    }

    [TestMethod]
    public void GetScore_returnsScrabbleScore_Int()
    {
    Score testScore = new Score();
    string testWord = "zebra";
    int wordScore = testScore.GetScore(testWord);
    Assert.AreEqual(wordScore, 16);
    }

    [TestMethod]
    public void GetScore_returnsDifferentScrabbleScore_Int()
    {
    Score testScore = new Score();
    string testWord = "candelabra";
    int wordScore = testScore.GetScore(testWord);
    Assert.AreEqual(wordScore, 15);
    }
  }
}
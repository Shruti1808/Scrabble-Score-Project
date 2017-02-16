using Xunit;
using ScrabbleGame.Objects;
using System;
using System.Collections.Generic;

namespace ScrabbleGameTest
{
    public class ScrabbleTest
    {
// this will test 1 point counting
        [Fact]
        public void testScore_addOnePointAlphabets_Score1()
        {
            //arrange
            string word = "AE" ;
            int score = 2;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int result = newScrabble.PointCount();
            Console.WriteLine(result);
            //assert
            Assert.Equal(score, result);
        }

// this will test two point counting
        [Fact]
        public void testScore_addTwoPointAlphabets_Score2()
        {
            //arrange
            string word = "D" ;
            int score = 2;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int result = newScrabble.PointCount();
            Console.WriteLine(result);
            //assert
            Assert.Equal(score, result);
        }
    }
}

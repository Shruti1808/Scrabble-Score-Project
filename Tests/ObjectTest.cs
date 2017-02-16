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
            string word = "A" ;
            int score = 1;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int result = newScrabble.PointCount();
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
            int result2 = newScrabble.PointCount();
            //assert
            Assert.Equal(score, result2);
        }
// this will test three point counting
        [Fact]
        public void testScore_addThreePointAlphabets_Score3()
        {
            //arrange
            string word = "B" ;
            int score = 3;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int result3 = newScrabble.PointCount();
            //assert
            Assert.Equal(score, result3);
        }

// this will test three point counting
        [Fact]
        public void testScore_addFourPointAlphabets_Score4()
        {
            //arrange
            string word = "F" ;
            int score = 4;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int result4 = newScrabble.PointCount();
            //assert
            Assert.Equal(score, result4);
        }
// this will test eight point counting
        [Fact]
        public void testScore_addEightPointAlphabets_Score8()
        {
            //arrange
            string word = "X" ;
            int score = 8;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int result8 = newScrabble.PointCount();
            //assert
            Assert.Equal(score, result8);
        }
// this will test ten point counting
        [Fact]
        public void testScore_addTenPointAlphabets_Score10()
        {
            //arrange
            string word = "Z" ;
            int score = 10;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int result10 = newScrabble.PointCount();
            //assert
            Assert.Equal(score, result10);
        }
// this will test for ALL point counting
        [Fact]
        public void testScore_addAllPointAlphabets_Score28()
        {
            //arrange
            string word = "ADBFJQ" ;
            int score = 28;
            Scrabble newScrabble = new Scrabble(word);
            //act
            int resultAll = newScrabble.PointCount();
            Console.WriteLine(resultAll);
            //assert
            Assert.Equal(score, resultAll);
        }
}
}

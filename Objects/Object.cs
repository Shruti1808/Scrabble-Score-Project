using System;
using System.Collections.Generic;

namespace ScrabbleGame.Objects
{
    public class Scrabble
    {
        private string _word;
        private int _score;
        private char[] _characterArray;
        private char[] _onePointArray;
        private char[] _twoPointArray;
        private char[] _threePointArray;
        private char[] _fourPointArray;
        private char[] _eightPointArray;
        private char[] _tenPointArray;

        public Scrabble(string word)
        {
            _word = word;
            _score = 0;
            _characterArray = word.ToUpper().ToCharArray();
            _onePointArray = new char[] {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
            _twoPointArray = new char[] {'D', 'G'};
            _threePointArray = new char[] {'B', 'C', 'M', 'P'};
            _fourPointArray = new char[] {'F', 'H', 'V', 'W', 'Y'};
            _eightPointArray = new char[] {'J', 'X'};
            _tenPointArray = new char[] {'Q', 'Z'};
        }

        public int PointCount()
        {
           for (int i = 0; i < _characterArray.Length; i++)
           {
               for (int j= 0; j < _onePointArray.Length; j++)
               {
                 if(_characterArray[i] == _onePointArray[j])
                 {
                     _score += 1;
                 }
               }
               for (int k= 0; k < _twoPointArray.Length; k++)
               {
                 if(_characterArray[i] == _twoPointArray[k])
                 {
                     _score += 2;
                 }
               }
               for (int l= 0; l < _threePointArray.Length; l++)
               {
                 if(_characterArray[i] == _threePointArray[l])
                 {
                     _score += 3;
                 }
               }
               for (int m= 0; m < _fourPointArray.Length; m++)
               {
                 if(_characterArray[i] == _fourPointArray[m])
                 {
                     _score += 4;
                 }
               }
               for (int n= 0; n < _eightPointArray.Length; n++)
               {
                 if(_characterArray[i] == _eightPointArray[n])
                 {
                     _score += 8;
                 }
               }
               for (int o= 0; o < _tenPointArray.Length; o++)
               {
                 if(_characterArray[i] == _tenPointArray[o])
                 {
                     _score += 10;
                 }
               }
           }
            return this._score;
        }


    }
}

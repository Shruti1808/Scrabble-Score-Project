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

        public Scrabble(string word)
        {
            _word = word;
            _score = 0;
            _characterArray = word.ToUpper().ToCharArray();
            _onePointArray = new char[] {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
             _twoPointArray = new char[] {'D', 'G'};
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
           }
            return _score;
        }


    }
}

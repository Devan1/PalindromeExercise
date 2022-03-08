using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //throw new NotImplementedException();
            var temp = word.Reverse();
            return word.SequenceEqual(temp);
        }
    }

}
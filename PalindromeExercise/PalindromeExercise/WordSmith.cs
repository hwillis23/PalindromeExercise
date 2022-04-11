using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reverse = "";

            for (int i = word.Length -1; i >= 0 ; i--)
            {
                reverse += word.ToLower()[i];
            }

            if (reverse == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

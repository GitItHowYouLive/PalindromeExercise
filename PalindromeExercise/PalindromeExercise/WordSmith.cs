using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var arr = word.ToCharArray();
            Array.Reverse(arr);
            var flip = "";
            for (int i = 0; i < arr.Length; i++)
            {
                flip += arr[i];
            }
            return flip == word;
        }
    }
}

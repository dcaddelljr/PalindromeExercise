using System;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace PalindromeExercise
{
	public class WordSmith
	{
	    public bool IsAPalindrome(string word)
        {
        var empty = word.Replace(" ", "");
        return empty.ToLower().SequenceEqual(empty.Reverse());
        }

    }
}


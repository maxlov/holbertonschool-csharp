using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>Class holds methods that manipul.</summary>
    public class Str
    {
        /// <summary>Determines if string is palindrome or not.</summary>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;
            string formatted = (string)s.Clone();
            formatted = Regex.Replace(formatted, @"[^\w]", "");
            formatted = formatted.ToLower();

            int start = 0;
            int end = formatted.Length - 1;
            for (; start < end; start++, end--)
                if (formatted[start] != formatted[end])
                    return false;
            return true;
        }
    }
}

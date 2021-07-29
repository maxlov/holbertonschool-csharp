using System;

namespace Text
{
    /// <summary>Class that holds methods for strings.</summary>
    public class Str
    {
        /// <summary>Determines word count of string.</summary>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            int wordcount = 1;
            foreach(char character in s)
                if (Char.IsUpper(character))
                    wordcount += 1;
            return wordcount;
        }
    }
}

using System;

namespace Text
{
    /// <summary>Class that holds methods for strings.</summary>
    public class Str
    {
        /// <summary>Gets first unique char of string.</summary>
        public static int UniqueChar(string s)
        {
            if (s.Length == 0)
                return -1;
            for (int idx = 0; idx < s.Length; idx++)
                if (!s.Remove(idx, 1).Contains(s[idx].ToString()))
                    return idx;
            return -1;
        }
    }
}

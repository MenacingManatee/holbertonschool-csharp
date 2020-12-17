using System;

namespace Text
{
    /// <summary>
    /// Class for methods involving strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines the first unique character in a string
        /// </summary>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
                return (-1);
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        count++;
                }
                if (count == 1)
                    return (i);
                count = 0;
            }
            return (-1);
        }
    }
}

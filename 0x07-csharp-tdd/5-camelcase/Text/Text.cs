using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Str class for string methods
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines the number of words in a string
        /// </summary>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
                return (0);
            string n = Regex.Replace(s, "[^A-Z]", "");
            return (1 + n.Length);
        }
    }
}

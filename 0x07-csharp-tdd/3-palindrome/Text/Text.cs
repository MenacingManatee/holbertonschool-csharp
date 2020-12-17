using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines if a string is a palindrome
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return (false);
            if (s == "")
                return (true);
            string n = s.ToLower();
            n = Regex.Replace(n, "[^a-z]*", "");
            char[] tmp = n.ToCharArray();
            Array.Reverse(tmp);
            string tmp2 = new string(tmp);
            return (n == tmp2);
        }
    }
}

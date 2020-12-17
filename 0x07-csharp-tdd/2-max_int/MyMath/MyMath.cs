using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Operations class for math operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds the largest in in a list
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return (0);
            List<int> l = new List<int>(nums);
            l.Sort();
            return (l[l.Count - 1]);
        }
    }
}

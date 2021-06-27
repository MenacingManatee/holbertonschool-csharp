using System;

namespace _6_print_comb2
{
    class Program
    {
        /// Writes '01' through '89', repeating no combination of digits
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;
            string sep = ", ";
            for (; i <= 8; i += 1)
            {
                for (j = i + 1; j <= 9; j += 1)
                {
                    Console.Write("{0}{1}", i, j);
                    if (i == 8 && j == 9)
                        sep = "\n";
                    Console.Write("{0}", sep);
                }
            }
        }
    }
}

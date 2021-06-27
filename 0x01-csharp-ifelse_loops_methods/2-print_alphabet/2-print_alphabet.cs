using System;

namespace _2_print_alphabet
{
    class Program
    {
        /// Writes the alphabet, converting int to chars
        static void Main(string[] args)
        {
            int i = (int)'a';
            for (; i <= (int)'z'; i += 1)
            {
                Console.Write("{0}", (char)i);
            }
        }
    }
}

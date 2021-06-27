using System;

namespace _3_print_alphabt
{
    class Program
    {
        /// Writes the alphabet, skipping 'q' and 'e'
        static void Main(string[] args)
        {
            int i = (int)'a';
            for (; i <= (int)'z'; i += 1)
            {
                if (i != (int)'e' && i != (int)'q')
                    Console.Write("{0}", (char)i);
            }
        }
    }
}

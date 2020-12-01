using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string sep = ", ";
            for (; i <= 99; i += 1)
            {
                Console.Write("{0:D2}", i);
                if (i == 99)
                    sep = "\n";
                Console.Write("{0}", sep);
            }
        }
    }
}

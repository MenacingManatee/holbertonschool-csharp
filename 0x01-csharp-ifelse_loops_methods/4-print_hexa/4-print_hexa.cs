using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; i <= 98; i += 1)
            {
                Console.Write("{0} = 0x{0:x}\n", i);
            }
        }
    }
}

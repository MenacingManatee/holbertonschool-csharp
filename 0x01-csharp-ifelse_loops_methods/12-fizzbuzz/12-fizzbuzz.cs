using System;

namespace _12_fizzbuzz
{
    class Program
    {
        /// Prints 1-100, printing 'Fizz' if divisible by 3 and 'Buzz' if divisible by 5
        static void Main(string[] args)
        {
            int i = 1;
            string str = "";
            for (; i <= 100; i++)
            {
                str = "";
                if (i % 3 == 0)
                    str += "Fizz";
                if (i % 5 == 0)
                    str += "Buzz";
                if (i % 3 != 0 && i % 5 != 0)
                    str += i;
                Console.Write(str);
                if (i != 100)
                    Console.Write(' ');
            }
        }
    }
}

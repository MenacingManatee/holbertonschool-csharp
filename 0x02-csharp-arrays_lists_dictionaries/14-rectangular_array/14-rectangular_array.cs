using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[5, 5];
            int i;
            int j;
            string sep = " ";
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j == 4)
                        sep = "\n";
                    if (i == 2 && j == 2)
                        m[i, j] = 1;
                    else
                        m[i, j] = 0;
                    Console.Write("{0}{1}", m[i, j], sep);
                }
                sep = " ";
            }
        }
    }
}

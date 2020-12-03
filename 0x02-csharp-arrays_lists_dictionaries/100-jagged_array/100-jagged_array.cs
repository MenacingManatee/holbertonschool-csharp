using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ja = new int[3][];
            ja[0] = new int[] {0, 1, 2, 3};
            ja[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
            ja[2] = new int[] {0, 1};
            string sep = " ";
            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].Length; j++)
                {
                    if (j == ja[i].Length - 1)
                        sep = "\n";
                    Console.Write("{0}{1}", ja[i][j], sep);
                }
                sep = " ";
            }
        }
    }
}

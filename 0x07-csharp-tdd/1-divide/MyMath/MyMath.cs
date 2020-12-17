using System;

namespace MyMath
{
    /// <summary>
    /// Operations class for math operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Divides all elements of a matrix
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            if (matrix == null)
                return (null);

            int l1 = matrix.GetLength(0);
            int l2 = matrix.GetLength(1);
            int[,] m = new int[l1, l2];

            for (int i = 0; i < l1; i++) {
                for (int j = 0; j < l2; j++) {
                    m[i, j] = matrix[i, j] / num;
                }
            }
            return (m);
        }
    }
}

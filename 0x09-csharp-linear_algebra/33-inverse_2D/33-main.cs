using System;
using System.Collections.Generic;

namespace _33_inverse_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_1 = new double[,] { {1, 2}, {3, 4} };
            double[,] matrix_2 = new double[,] { {3, 6}, {9, 12}, {15, 18} };
            double[,] tmp;

            tmp = MatrixMath.Inverse2D(matrix_1);
            PrintMatrix(tmp);
            tmp = MatrixMath.Inverse2D(matrix_2);
            PrintMatrix(tmp);
            
        }
        static void PrintMatrix(double[,] matrix)
        {
            Console.Write("{");
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("{");
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j != matrix.GetLength(1) - 1)
                        Console.Write(", ");
                }
                Console.Write("}");
                if (i != matrix.GetLength(0) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}

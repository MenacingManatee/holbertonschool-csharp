using System;
using System.Collections.Generic;

namespace _25_matrix_transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_2 = new double[,] { {3, 6, 9}, {12, 15, 18} };
            double[,] matrix_3 = new double[,] { {3, 6}, {9, 12}, {15, 18} };
            double[,] tmp;

            tmp = MatrixMath.Transpose(matrix_2);
            PrintMatrix(tmp);
            tmp = MatrixMath.Transpose(matrix_3);
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

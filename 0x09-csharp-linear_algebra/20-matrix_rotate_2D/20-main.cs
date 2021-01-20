using System;
using System.Collections.Generic;

namespace _20_matrix_rotate
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_2D = new double[,] { {1, 2}, {3, 4} };
            double angle = -1.57;
            double[,] tmp;

            tmp = MatrixMath.Rotate2D(matrix_2D, angle);
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
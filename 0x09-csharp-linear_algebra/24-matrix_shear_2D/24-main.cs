using System;
using System.Collections.Generic;

namespace _24_matrix_shear_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_2D = new double[,] { {1, 2}, {3, 4} };
            char dir = 'x';
            double s = 2;
            double[,] tmp;

            tmp = MatrixMath.Shear2D(matrix_2D, dir, s);
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
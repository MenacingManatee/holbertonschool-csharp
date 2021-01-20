using System;
using System.Collections.Generic;

namespace _3_magnitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_2D = new double[,] { {2, 2}, {6, 4} };
            double scalar_2D = 0.5;
            double[,] matrix_3D = new double[,] { {-13, 10, 8}, {2, 0, 14}, {-4, -5, 2} };
            double scalar_3D = 4;
            double[,] tmp;

            tmp = MatrixMath.MultiplyScalar(matrix_2D, scalar_2D);
            PrintMatrix(tmp);
            tmp = MatrixMath.MultiplyScalar(matrix_3D, scalar_3D);
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
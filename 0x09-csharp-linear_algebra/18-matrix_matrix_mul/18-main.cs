using System;
using System.Collections.Generic;

namespace _18_matrix_matrix_mul
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_2D_1 = new double[,] { {2, 3}, {-1, 0} };
            double[,] matrix_2D_2 = new double[,] { {1, 7}, {-8, -2} };
            double[,] matrix_3D_1 = new double[,] { {14, -3, 0}, {-11, -5, 3}, {2, -9, 13} };
            double[,] matrix_3D_2 = new double[,] { {6, 16, 21}, {5, 2, 0}, {1, 3, 7} };
            double[,] tmp;

            tmp = MatrixMath.Multiply(matrix_2D_1, matrix_2D_2);
            Console.Write("{");
            for (var i = 0; i < tmp.GetLength(0); i++)
            {
                Console.Write("{");
                for (var j = 0; j < tmp.GetLength(1); j++)
                {
                    Console.Write(tmp[i, j]);
                    if (j != tmp.GetLength(1) - 1)
                        Console.Write(", ");
                }
                Console.Write("}");
                if (i != tmp.GetLength(0) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
            tmp = MatrixMath.Multiply(matrix_3D_1, matrix_3D_2);
            Console.Write("{");
            for (var i = 0; i < tmp.GetLength(0); i++)
            {
                Console.Write("{");
                for (var j = 0; j < tmp.GetLength(1); j++)
                {
                    Console.Write(tmp[i, j]);
                    if (j != tmp.GetLength(1) - 1)
                        Console.Write(", ");
                }
                Console.Write("}");
                if (i != tmp.GetLength(0) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}
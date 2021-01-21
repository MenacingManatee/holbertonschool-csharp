using System;
using System.Collections.Generic;

namespace _28_determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_2 = new double[,] { {2, 2}, {-9, 4} };
            double[,] matrix_3 = new double[,] { {-4, 9, 0}, {1, -2, 1}, {3, -4, 2} };
            double[,] matrix_e = new double[,] {{}};

            Console.WriteLine(MatrixMath.Determinant(matrix_2));
            Console.WriteLine(MatrixMath.Determinant(matrix_3));
            Console.WriteLine(MatrixMath.Determinant(matrix_e));
            
        }
    }
}

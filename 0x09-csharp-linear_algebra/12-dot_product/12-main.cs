using System;
using System.Collections.Generic;

namespace _12_dot_product
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector_2D_1 = new double[] {1, 3};
            double[] vector_2D_2 = new double[] {-2, 5};
            double[] vector_3D_1 = new double[] {-4, 0, 10};
            double[] vector_3D_2 = new double[] {3, 7, -9};

            Console.WriteLine(VectorMath.DotProduct(vector_2D_1, vector_2D_2));
            Console.WriteLine(VectorMath.DotProduct(vector_3D_1, vector_3D_2));
        }
    }
}
using System;
using System.Collections.Generic;

namespace _3_magnitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector_2D = new double[] {3, 9};
            double[] vector_3D = new double[] {7, -3, -9};
            Console.WriteLine(VectorMath.Magnitude(vector_2D));
            Console.WriteLine(VectorMath.Magnitude(vector_3D));
        }
    }
}

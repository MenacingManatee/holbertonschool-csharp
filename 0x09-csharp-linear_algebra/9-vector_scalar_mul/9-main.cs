using System;
using System.Collections.Generic;

namespace _9_vector_scalar_mul
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector_2D = new double[] {98, 972};
            double[] vector_3D = new double[] {0, -16, 31};
            double[] tmp;
            double scalar_1 = 0.5;
            double scalar_2 = 4;
            int count = 0;

            tmp = VectorMath.Multiply(vector_2D, scalar_1);
            Console.Write("(");
            foreach (var item in tmp)
            {
                Console.Write(item);
                if (count != tmp.Length - 1)
                {
                    Console.Write(", ");
                }
                count += 1;
            }
            Console.WriteLine(")");
            tmp = VectorMath.Multiply(vector_3D, scalar_2);
            count = 0;
            Console.Write("(");
            foreach (var item in tmp)
            {
                Console.Write(item);
                if (count != tmp.Length - 1)
                {
                    Console.Write(", ");
                }
                count += 1;
            }
            Console.Write(")");
        }
    }
}
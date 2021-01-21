using System;
using System.Collections.Generic;

namespace _18_vector_vector_mul
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector1 = new double[] {2, -2, 1};
            double[] vector2 = new double[] {-8, 8, -4};
            double[] vector3 = new double[] {2, 1, -1};
            double[] vector4 = new double[] {-3, 4, 1};
            double[] tmp;

            tmp = VectorMath.CrossProduct(vector1, vector2);
            PrintVector(tmp);
            tmp = VectorMath.CrossProduct(vector3, vector4);
            PrintVector(tmp);
        }
        static void PrintVector(double[] vector)
        {
            Console.Write("{");
            for (var i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]);
                if (i != vector.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("}");
        }
    }
    
}
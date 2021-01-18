using System;
using System.Collections.Generic;

namespace _3_magnitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector_2D_1 = new double[] {-4, 9};
            double[] vector_2D_2 = new double[] {8, -11};
            double[] vector_3D_1 = new double[] {14, -2, 0};
            double[] vector_3D_2 = new double[] {-3, 23, 50};
            double[] tmp;
            int count = 0;

            tmp = VectorMath.Add(vector_2D_1, vector_2D_2);
            Console.Write("{");
            foreach (var item in tmp)
            {
                Console.Write(item);
                if (count != tmp.Length - 1)
                {
                    Console.Write(", ");
                }
                count += 1;
            }
            Console.WriteLine("}");
            tmp = VectorMath.Add(vector_3D_1, vector_3D_2);
            count = 0;
            Console.Write("{");
            foreach (var item in tmp)
            {
                Console.Write(item);
                if (count != tmp.Length - 1)
                {
                    Console.Write(", ");
                }
                count += 1;
            }
            Console.Write("}");
        }
    }
}
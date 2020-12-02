using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int i;
        int j;
        for (j = 0; j < length; j++)
        {
            for (i = 0; i < j; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine('\\');
        }
        Console.Write('\n');
    }
}

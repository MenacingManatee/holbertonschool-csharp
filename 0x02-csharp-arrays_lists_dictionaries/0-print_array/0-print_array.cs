using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.Write("\n");
            return new int[0];
        }
        int[] res = new int[size];
        string sep = " ";
        for (int count = 0; count < size; count++)
        {
            if (count + 1 == size)
                sep = "\n";
            res[count] = count;
            Console.Write("{0}{1}", count, sep);
        }
        return res;
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
            Console.Write("\n");
        List<int> l = new List<int>();
        int i;
        string sep = " ";
        for (i = 0; i < size; i++)
        {
            if (i == size - 1)
                sep = "\n";
            l.Add(i);
            Console.Write("{0}{1}", i, sep);
        }
        return l;
    }
}

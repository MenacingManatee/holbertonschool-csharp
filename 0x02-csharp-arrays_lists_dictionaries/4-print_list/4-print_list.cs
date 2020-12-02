using System;
using System.Collections;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> l;
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

using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> LL = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            LL.AddLast(i);
            Console.WriteLine(LL.Last.Value);
        }
        return LL;
    }
}

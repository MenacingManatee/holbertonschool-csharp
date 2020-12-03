using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        var node = myLList.First;
        int sum = 0;

        while (node != null)
        {
            sum += node.Value;
            node = node.Next;
        }
        return sum;
    }
}

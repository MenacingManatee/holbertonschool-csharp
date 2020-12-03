using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        var node = myLList.First;

        for (int count = 0; node != null; count++, node = node.Next)
        {
            if (node.Value == value)
                return count;
        }
        return -1;
    }
}

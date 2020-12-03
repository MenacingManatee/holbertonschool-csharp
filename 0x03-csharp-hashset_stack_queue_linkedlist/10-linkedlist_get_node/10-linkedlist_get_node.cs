using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        var node = myLList.First;

        for (int count = 0; count < myLList.Count && node != null; count++, node = node.Next)
        {
            if (count == n)
            {
                return node.Value;
            }
        }
        return 0;
    }
}

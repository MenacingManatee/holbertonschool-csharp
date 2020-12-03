using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        var node = myLList.First;
        int count;

        for (count = 0; count < index && count < myLList.Count; count++)
        {
            node = node.Next;
        }
        if (count == index)
            myLList.Remove(node);
    }
}

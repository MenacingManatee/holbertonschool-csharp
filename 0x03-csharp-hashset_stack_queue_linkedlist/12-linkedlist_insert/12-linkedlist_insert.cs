using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        var node = myLList.First;

        if (myLList.Count == 0)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        while (node != null)
        {
            if (node.Value >= n)
            {
                myLList.AddBefore(node, n);
                return node.Previous;
            }
            node = node.Next;
        }
        return myLList.First; //Should be redundant
    }
}

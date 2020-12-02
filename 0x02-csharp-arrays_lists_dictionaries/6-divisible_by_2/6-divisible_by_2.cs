using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> l = new List<bool>();
        int i;
        for (i = 0; i < myList.Count; i++)
        {
            l.Add(myList[i] % 2 == 0);
        }
        return l;
    }
}

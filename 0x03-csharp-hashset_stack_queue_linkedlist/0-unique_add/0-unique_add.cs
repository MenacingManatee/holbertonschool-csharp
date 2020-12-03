using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var hs =  new HashSet<int>(myList);
        int sum = 0;
        int[] l = new int[hs.Count];
        hs.CopyTo(l);
        for (int i = 0; i < l.Length; i++)
            sum += l[i];
        return sum;
    }
}

﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int i;
        int mx = myList[0];
        for (i = 0; i < myList.Count; i++)
        {
            if (myList[i] >= mx)
                mx = myList[i];
        }
        return mx;
    }
}

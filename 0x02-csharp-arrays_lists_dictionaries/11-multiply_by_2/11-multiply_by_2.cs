using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> tmp = new Dictionary<string, int>();
        foreach(KeyValuePair<string, int> e in myDict)
            tmp[e.Key] = e.Value * 2;
        return tmp;
    }
}

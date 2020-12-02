using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var l = myDict.Keys.ToList();
        l.Sort();
        foreach (var k in l)
        {
            Console.WriteLine("{0}: {1}", k, myDict[k]);
        }
    }
}

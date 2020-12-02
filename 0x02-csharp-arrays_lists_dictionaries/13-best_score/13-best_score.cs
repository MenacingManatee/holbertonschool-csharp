using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bk = "None";
        int big = -1;
        foreach (KeyValuePair<string, int> e in myList)
        {
            if (e.Value >= big)
            {
                big = e.Value;
                bk = e.Key;
            }
        }
        return bk;
    }
}

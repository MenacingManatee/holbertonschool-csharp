using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count;

        for (count = 0; count < n; count++)
        {
            try {
                Console.WriteLine(myList[count]);
            } catch (ArgumentOutOfRangeException) {
                break;
            }
        }
        return count;
    }
}

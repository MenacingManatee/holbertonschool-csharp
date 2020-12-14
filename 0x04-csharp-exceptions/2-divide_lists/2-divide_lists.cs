using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> l = new List<int>();
        int res = 0;
        for (int count = 0; count < listLength; count++)
        {
            try {
                res = list1[count] / list2[count];
                l.Add(res);
            } catch (DivideByZeroException) {
                res = 0;
                Console.WriteLine("Cannot divide by zero");
                l.Add(res);
            } catch (ArgumentOutOfRangeException) {
                Console.WriteLine("Out of range");
                return l;
            }
            res = 0;
        }
        return l;
    }
}

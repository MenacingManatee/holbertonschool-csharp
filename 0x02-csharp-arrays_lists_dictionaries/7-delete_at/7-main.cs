﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

        List.DeleteAt(myList, 2);

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

        List.DeleteAt(myList, 5);

        foreach (int i in myList)
            Console.WriteLine(i);
    }
}

﻿using System;

class Program
{
    /// Writes variables to the console in a different order than provided
    static void Main(string[] args)
    {
        string str1 = "Street";
        string str2 = "Mission";
        int int1 = 972;
        Console.WriteLine("{2} {1} {0}", str1, str2, int1);
    }
}

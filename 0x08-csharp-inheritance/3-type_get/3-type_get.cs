using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach(var tmp in myObj.GetType().GetProperties()) {
            Console.WriteLine(tmp.Name);
        }
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach(var tmp in myObj.GetType().GetMethods()) {
            Console.WriteLine(tmp.Name);
        }
    }
}
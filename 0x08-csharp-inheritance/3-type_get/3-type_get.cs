using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Obj class for checking inheritance and type </summary>
class Obj
{
    /// <summary> Prints all properties and methods of an object </summary>
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
using System;
using System.Collections.Generic;

/// <summary> Obj class for checking inheritance and type </summary>
class Obj
{
    /// <summary> Checks if input object is an array
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj) || obj.GetType().IsSubclassOf(typeof(Array)));
    }
}


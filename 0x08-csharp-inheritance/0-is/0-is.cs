using System;
using System.Collections.Generic;

/// <summary> Obj class for checking inheritance and type </summary>
class Obj
{
    /// <summary> Checks if input object is an int </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return (typeof(int).IsInstanceOfType(obj));
    }
}

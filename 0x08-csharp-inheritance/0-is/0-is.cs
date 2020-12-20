using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        return (typeof(int).IsInstanceOfType(obj));
    }
}

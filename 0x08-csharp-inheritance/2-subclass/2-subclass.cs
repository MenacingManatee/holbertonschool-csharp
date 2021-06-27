using System;

/// <summary> Obj class for checking inheritance and type </summary>
class Obj
{
    /// <summary> Checks if input derivedType is a subclass of input baseType
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}

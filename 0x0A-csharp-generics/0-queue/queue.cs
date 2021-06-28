using System;

/// <summary> Queue class for generics </summary>
class Queue<T>
{
    /// <summary> Returns type using generics </summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}

using System;

/// <summary> Shape class, serves as base class for inheritance of any shape classes </summary>
class Shape
{
    /// <summary> Finds the area of a Shape - Currently unimplemented </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

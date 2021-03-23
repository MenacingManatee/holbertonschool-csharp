using System;

// <summary> Abstract base class </summary>
abstract class Base
{
    public string name {get; set;}

    public override string ToString()
    {
        return (String.Format("{0} is a {1}", name, this.GetType().ToString()));
    }
}

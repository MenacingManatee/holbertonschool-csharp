using System;

/// <summary> Abstract base class </summary>
public abstract class Base
{
    /// <summary> name string </summary>
    public string name {get; set;}

    /// <summary> Override for ToString method </summary>
    public override string ToString()
    {
        return (String.Format("{0} is a {1}", name, this.GetType().ToString()));
    }
}

/// <summary> Interactive interface </summary>
public interface IInteractive {
    /// <summary> Interactions </summary>
    void Interact();
}

/// <summary> Breakable interface </summary>
public interface IBreakable {
    /// <summary> Item durability tracker </summary>
    int durability {get; set;}
    /// <summary> Break an item </summary>
    void Break();
}

/// <summary> Collectable interface </summary>
public interface ICollectable {
    /// <summary> Is the object collected </summary>
    bool isCollected {get; set;}
    /// <summary> Collect the object </summary>
    void Collect();
}

/// <summary> Inherits from Base Interactive interface </summary>
public class Door : Base, IInteractive {
    /// <summary> Door constructor </summary>
    public Door(string n="Door") {
        this.name = n;
    }
    /// <summary> Called when interacting </summary>
    public void Interact() {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}
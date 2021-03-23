using System;

// <summary> Abstract base class </summary>
public abstract class Base
{
    // <summary> name string </summary>
    public string name {get; set;}

    // <summary> Override for ToString method </summary>
    public override string ToString()
    {
        return (String.Format("{0} is a {1}", name, this.GetType().ToString()));
    }
}

// <summary> Interactive interface </summary>
interface IInteractive {
    // <summary> Interactions </summary>
    void Interact();
}

// <summary> Breakable interface </summary>
interface IBreakable {
    // <summary> Item durability tracker </summary>
    int durability {get; set;}
    // <summary> Break an item </summary>
    void Break();
}

// <summary> Collectable interface </summary>
interface ICollectable {
    // <summary> Is the object collected </summary>
    bool isCollected {get; set;}
    // <summary> Collect the object </summary>
    void Collect();
}

// <summary> Inherits from Base and all 3 interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable {
    // <summary> item durability tracker </summary>
    public int durability {get; set; }
    // <summary> item collection tracker </summary>
    public bool isCollected {get; set; }

    // <summary> When object interacts with something </summary>
    public void Interact() {}
    // <summary> When object breaks </summary>
    public void Break() {}
    // <summary> When object collects something </summary>
    public void Collect() {}
}
using System;

// <summary> Abstract base class </summary>
abstract class Base
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
    void Interact();
}

// <summary> Breakable interface </summary>
interface IBreakable {
    int durability {get; set;}
    void Break();
}

// <summary> Collectable interface </summary>
interface ICollectable {
    bool isCollected {get; set;}
    void Collect();
}

// <summary> Inherits from Base and all 3 interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable {
    public int durability {get; set; }
    public bool isCollected {get; set; }

    public void Interact() {}
    public void Break() {}
    public void Collect() {}
}
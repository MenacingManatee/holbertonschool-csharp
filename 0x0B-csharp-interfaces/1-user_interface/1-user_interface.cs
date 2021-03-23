using System;

abstract class Base
{
    public string name;

    public override string ToString()
    {
        return (String.Format("{0} is a {1}", name, this.GetType().ToString()));
    }
}
interface IInteractive {
    void Interact() {
        //empty method
    }
}
interface IBreakable {
    int durability {get; set;}
    void Break() {
        //empty method
    }
}
interface ICollectable {
    bool isCollected {get; set;}
    void Collect() {
        // empty method
    }
}
class TestObject : Base, IInteractive, IBreakable, ICollectable {
    void ICollectable.Collect() {}
    public int durability {get; set; }
    public bool isCollected {get; set; }
}
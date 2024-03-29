﻿using System;

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
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}
/// <summary> Inherits from Base, and interactive and breakable interfaces </summary>
public class Decoration : Base, IInteractive, IBreakable {
    /// <summary> Is the item a quest item </summary>
    public bool isQuestItem;
    /// <summary> Object durability </summary>
    public int durability {get; set; }

    /// <summary> Decoration constructor </summary>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false) {
        if (durability <= 0) {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.isQuestItem = isQuestItem;
        this.durability = durability;
    }
    /// <summary> Called on interaction </summary>
    public void Interact() {
        if (durability <= 0) {
            Console.WriteLine("The {0} has been broken.", name);
        }
        else if (isQuestItem == true) {
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        }
        else {
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
        }
    }
    /// <summary> Called on damage </summary>
    public void Break() {
        durability--;
        if (durability > 0) {
            Console.WriteLine("You hit the {0}. It cracks.", name);
        }
        if (durability == 0) {
            Console.WriteLine("You smash the {0}. What a mess.", name);
        }
        if (durability < 0) {
            Console.WriteLine("The {0} is already broken.", name);
        }
    }
}

/// <summary> Inherits from Base and collectable interface </summary>
public class Key : Base, ICollectable {
    /// <summary> Has the key been collected </summary>
    public bool isCollected {get; set;}
    /// <summary> Key constructor </summary>
    public Key(string name="Key", bool isCollected=false) {
        this.name = name;
        this.isCollected = isCollected;
    }
    /// <summary> Collect key </summary>
    public void Collect() {
        if (isCollected == false) {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        else {
            Console.WriteLine("You have already picked up the {0}.", name);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

/// <summary> Item Class </summary>
public class Item : BaseClass
{
    /// <summary> Name string of item </summary>
    public string name { get; set; }
    /// <summary> Optional description </summary>
    public string description { get; set; }
    /// <summary> Optional price </summary>
    public float price { get; set; }
    /// <summary> Optional list of tags </summary>
    public string[] tags { get; set; }
    /// <summary> Item constructor </summary>
    public Item(string name, string description=null, float price=-1, string[] tags=null) {
        this.name = name;
        this.description = description;
        if (price != -1) {
            this.price = (float)Math.Round(price * 100f) / 100f;
        }
        this.tags = tags;
    }
}

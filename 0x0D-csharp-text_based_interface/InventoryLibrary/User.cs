using System;

/// <summary> User Class </summary>
public class User : BaseClass
{
    /// <summary> Name string of User </summary>
    public string name { get; set; }
    /// <summary> User constructor </summary>
    public User(string name) {
        this.name = name;
    }
}

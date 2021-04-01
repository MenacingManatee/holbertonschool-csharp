using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

/// <summary> Storage Class using JSON </summary>
public class JSONStorage
{
    /// <summary> Dictionary of objects to be saved </summary>
    public Dictionary<string, dynamic> objects { get; set; } = new Dictionary<string, dynamic>();
    /// <summary> User constructor </summary>
    public Dictionary<string, dynamic> All() {
        return (objects);
    }
    /// <summary> Adds new object to dictionary </summary>
    public void New(BaseClass obj) {
        string key;

        if (obj == null)
            return;
        key = String.Format("{0}.{1}", obj.GetType(), obj.id);
        this.objects.Add(key, obj);
    }
    /// <summary> Saves all objects to file </summary>
    public void Save() {
        string jsonString = JsonSerializer.Serialize(this.objects);

        Directory.CreateDirectory("storage");
        File.WriteAllText("storage/inventory_manager.json", jsonString);
    }
    public void Load() {
        Dictionary<string, dynamic> tmp = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(File.ReadAllText("storage/inventory_manager.json"));
        
        this.objects = tmp;
    }
}

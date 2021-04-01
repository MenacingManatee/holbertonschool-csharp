using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage storage = new JSONStorage();

            storage.Load();
            string prompt = @"Inventory Manager
-------------------------
<ClassNames> show all ClassNames of objects
<All> show all objects
<All [ClassName]> show all objects of a ClassName
<Create [ClassName]> a new object
<Show [ClassName object_id]> an object
<Update [ClassName object_id]> an object
<Delete [ClassName object_id]> an object
<Exit>
";
            string[] types = {"BaseClass", "User", "Item", "Inventory"};

            Console.Write(prompt);
            for (string r = Console.ReadLine(); r != null; r = Console.ReadLine()) {
                string[] commands = r.Split(' ');
                if (string.Compare(commands[0], "Exit", true) == 0)
                    break;
                if (commands[0].Length == 0) {
                    continue;
                }
                var a = storage.All();
                bool cFlag = false;
                bool iFlag = false;
                if (commands.Length >= 2) {
                    foreach (var type in types) {
                        if (string.Compare(commands[1], type, true) == 0)
                            cFlag = true;
                    }
                    if (cFlag == false) {
                        Console.WriteLine("{0} is not a valid object type", commands[1]);
                        continue;
                    }
                }
                if (commands.Length >= 3) {
                    foreach (var o in a.Values) {
                        if (string.Compare(o.id, commands[2], true) == 0)
                            iFlag = true;
                    }
                    if (iFlag == false) {
                        Console.WriteLine("Object {0} could not be found", commands[2]);
                        continue;
                    }
                }
                if (string.Compare(commands[0], "All", true) == 0) {
                    if (commands.Length == 1){
                        foreach (var key in a.Keys) {
                            Console.WriteLine("{0} {1}", key, a[key].ToString());
                        }
                    }
                    else {
                        foreach (var key in a.Keys) {
                            if (string.Compare(a[key].type, commands[1], true) == 0) {
                                Console.WriteLine("{0} {1}", key, a[key].ToString());
                            }
                        }
                    }
                }
                else if (string.Compare(commands[0], "Show", true) == 0) {
                    string key = string.Format("{0}.{1}", commands[1], commands[2]);
                    if (a.ContainsKey(key)) {
                        Console.WriteLine(a[key]);
                    }
                    else {
                        Console.WriteLine("Object {0} could not be found", commands[2]);
                    }
                }
                else if (string.Compare(commands[0], "Update", true) == 0) {
                    string key = string.Format("{0}.{1}", commands[1], commands[2]);
                    if (a.ContainsKey(key)) {
                        storage.objects[key].date_updated = DateTime.Now;
                        storage.Save();
                    }
                    else {
                        Console.WriteLine("Object {0} could not be found", commands[2]);
                    }
                }
                else if (string.Compare(commands[0], "Delete", true) == 0) {
                    string key = string.Format("{0}.{1}", commands[1], commands[2]);
                    if (a.ContainsKey(key)) {
                        storage.objects.Remove(key);
                        storage.Save();
                    }
                    else {
                        Console.WriteLine("Object {0} could not be found", commands[2]);
                    }
                }
                else if (string.Compare(commands[0], "ClassNames", true) == 0) {
                    List<string> names = new List<string>();
                    foreach (var v in a.Values) {
                        names.Add(v.GetType().ToString());
                    }
                    names = names.Distinct().ToList();
                    string res = string.Join(", ", names);
                    Console.WriteLine(res);
                }
                else {
                    Console.WriteLine("{0} is not a valid command", commands[0]);
                    continue;
                }
                Console.Write(prompt);
            }
        }
    }
}

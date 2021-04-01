using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Linq;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage storage = new JSONStorage();
            User u = new User("Test User 2");
            Item i = new Item("Test Item", "Blank desc", 2.99f);

            storage.New(u);
            storage.New(i);
            storage.Save();
            var l1 = storage.All().Values.ToList();
            storage.Load();
            var l = storage.All().Values.ToList();
            l.ForEach(Console.WriteLine);
            Console.WriteLine(File.Exists("storage/inventory_manager.json"));
        }
    }
}

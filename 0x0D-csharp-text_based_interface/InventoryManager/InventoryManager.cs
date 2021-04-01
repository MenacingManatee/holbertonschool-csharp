using System;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage storage = new JSONStorage();

            storage.Load();
            User testobj = new User("Test User");
            storage.New(testobj);
            storage.Save();
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
            Console.Write(prompt);
            for (string r = Console.ReadLine(); r != null; r = Console.ReadLine()) {
                string s;
                if (r.Length >= 3)
                    s = r.Substring(0, 3);
                else
                    continue;
                if (string.Compare(s, "All", true) == 0) {
                    var a = storage.All();
                    foreach (var key in a.Keys) {
                        Console.WriteLine("{0} {1}", key, a[key].ToString());
                    }
                }
                else if (string.Compare(r, "Exit", true) == 0)
                    break;
                Console.Write(prompt);
            }
        }
    }
}

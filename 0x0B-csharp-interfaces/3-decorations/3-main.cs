using System;

class Program
{
    static void Main(string[] args)
    {
        Decoration coffeeMug = new Decoration("Coffee Mug", 2);

        Console.WriteLine(coffeeMug.ToString());

        coffeeMug.Interact();
        coffeeMug.Break();
        coffeeMug.Break();
        coffeeMug.Interact();
        try {
            Decoration badDurability = new Decoration("Deco", -1);
        }
        catch (Exception e) {
            Console.WriteLine(e);
        }
        Decoration questItem = new Decoration("Quest Item", 10, true);
        questItem.Interact();
    }
}
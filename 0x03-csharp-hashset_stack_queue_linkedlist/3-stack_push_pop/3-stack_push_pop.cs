using System;
using System.Collections.Generic;

class MyStack
{
    // Main - entry point
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count != 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        bool srch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, srch);
        while (aStack.Count != 0 && aStack.Contains(search))
        {
            string tmp = aStack.Pop();
            if (tmp == search)
            {
                break;
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}

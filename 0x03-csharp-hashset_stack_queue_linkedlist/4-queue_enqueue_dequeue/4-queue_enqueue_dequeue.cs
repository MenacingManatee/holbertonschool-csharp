using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count != 0)
            Console.WriteLine("First item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Queue is empty");
        bool srch = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, srch);
        while (aQueue.Count != 0 && aQueue.Contains(search))
        {
            string tmp = aQueue.Dequeue();
            if (tmp == search)
            {
                break;
            }
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}

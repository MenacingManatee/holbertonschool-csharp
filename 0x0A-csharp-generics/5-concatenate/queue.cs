using System;
using System.ComponentModel;

/// <summary> Queue class using generics </summary>
class Queue<T>
{
    /// <summary> Head node of queue </summary>
    public Node head = null;
    /// <summary> Tail node of queue </summary>
    public Node tail = null;
    /// <summary> Length of queue </summary>
    public int count = 0;

    /// <summary> Checks type of queue using generics </summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }

    /// <summary> Adds a node to the end of the queue </summary>
    public void Enqueue(T val) {
        Node n = new Node(val);
        Node h = head;

        if (head == null) {
            head = n;
        }
        if (tail != null)
            tail.next = n;
        else
            head.next = n;
        tail = n;
        count++;
    }

    /// <summary> Removes a node from the head of the queue </summary>
    public T Dequeue() {
        Node n;

        if (head == null || count == 0) {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        else
        {
            Node h = head;
            n = head.next;
            head = n;
            count--;
            return h.value;
        }
    }

    /// <summary> Returns the length of the queue </summary>
    public int Count()
    {
        return (count);
    }

    /// <summary> Returns the value of the head node </summary>
    public T Peek()
    {
        if (head == null || count == 0) {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (head.value);
    }

    /// <summary> Prints the values of the full queue </summary>
    public void Print()
    {
        Node c = head;
        if (head == null || count == 0) {
            Console.WriteLine("Queue is empty");
            return;
        }
        for (int i = 0; i < count; i++) {
            Console.WriteLine(c.value);
            c = c.next;
        }
    }

    /// <summary> Returns a concatenated string if the queue is a string or character queue </summary>
    public string Concatenate()
    {
        if (head == null || count == 0) {
            Console.WriteLine("Queue is empty");
            return (null);
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char)) {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }
        string res = "";
        Node c = head;
        for (int i = 0; i < count; i ++) {
            res += c.value;
            c = c.next;
        }
        return (res);
    }

    /// <summary> Node class to be contained in queue </summary>
    public class Node
    {
        public T value;
        public Node next = null;

        /// <summary> Constructor for Node </summary>
        public Node(T val)
        {
            value = val;
        }
    }
}

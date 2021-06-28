using System;

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

        if (head == null) {
            head = n;
        }
        tail = n;
        count++;
    }

    /// <summary> Returns the length of the queue </summary>
    public int Count()
    {
        return (count);
    }

    /// <summary> Node class to be contained in queue </summary>
    public class Node
    {
        public T value;
        public Node next = null;

        /// <summary> Constructor for node </summary>
        public Node(T val)
        {
            value = val;
        }
    }
}

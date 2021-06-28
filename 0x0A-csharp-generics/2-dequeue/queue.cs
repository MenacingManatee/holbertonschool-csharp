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

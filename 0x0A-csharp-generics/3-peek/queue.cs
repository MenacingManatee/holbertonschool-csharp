using System;
using System.ComponentModel;

class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count = 0;
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
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
    public int Count()
    {
        return (count);
    }
    public T Peek()
    {
        if (head == null || count == 0) {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (head.value);
    }
    public class Node
    {
        public T value;
        public Node next = null;

        public Node(T val)
        {
            value = val;
        }
    }
}

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

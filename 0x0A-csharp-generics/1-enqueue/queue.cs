using System;

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

        if (head == null) {
            head = n;
        }
        tail = n;
        count++;
    }
    public int Count()
    {
        return (count);
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

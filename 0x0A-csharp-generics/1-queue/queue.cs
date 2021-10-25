using System;

/// <summary>Class implementing a queue.</summary>
class Queue<T>
{
    /// <summary>Node class</summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T inputValue)
        {
            value = inputValue;
        }
    }

    Node head;
    Node tail;
    int count;

    /// <summary>Creates a node and adds it to the end of the queue.</summary>
    public void Enqueue(T t)
    {
        Node newNode = new Node(t);
        if (head == null)
            head = newNode;
        else
            tail.next = newNode;
        tail = newNode;
        count += 1;
    }

    /// <summary>Returns number of nodes.</summary>
    public int Count()
    {
        return count;
    }

    /// <summary>Returns this queue's type.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}

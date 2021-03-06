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

    /// <summary>Removes the first node of the queue.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            count -= 1;
            Node temp = head;
            head = head.next;
            T oldVal = temp.value;
            temp = null;
            return oldVal;
        }
        
    }

    /// <summary>Returns value of first node.</summary>
    public T Peek()
    {
        if (head != null)
            return head.value;
        Console.WriteLine("Queue is empty");
        return default(T);
    }

    /// <summary>Prints each value of Queue</summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        for (Node temp = head; temp != null; temp = temp.next)
            Console.WriteLine(temp.value);
    }

    /// <summary>Concatenates each value of queue if queue is string or char</summary>
    public string Concatenate()
    {
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        string concatedString = "";
        for (Node temp = head; temp != null; temp = temp.next)
        {
            concatedString += temp.value;
            if (temp.next != null && typeof(T) != typeof(char))
                concatedString += ' ';
        }
        return concatedString;
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

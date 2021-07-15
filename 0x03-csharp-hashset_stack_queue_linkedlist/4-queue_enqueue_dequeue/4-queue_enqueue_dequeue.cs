using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = aQueue.Count;
        Console.WriteLine($"Number of items: {count}");

        if (count > 0)
            Console.WriteLine($"Top item: {aQueue.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        bool check = aQueue.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {check}");
        if (check)
            while (aQueue.Dequeue() != search) {};

        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = aStack.Count;
        Console.WriteLine($"Number of items: {count}");

        if (count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        bool check = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {check}");
        if (check)
            while (aStack.Pop() != search) {};

        aStack.Push(newItem);
        return aStack;
    }
}
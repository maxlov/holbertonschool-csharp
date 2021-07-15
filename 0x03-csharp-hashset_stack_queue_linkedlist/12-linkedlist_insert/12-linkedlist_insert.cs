using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0)
                return myLList.AddFirst(n);
        LinkedListNode<int> current = myLList.First;
        while (current.Next != null)
        {
            if (current.Value > n)
                return myLList.AddBefore(current, n);
            current = current.Next;
        }
        return current;
    }
}
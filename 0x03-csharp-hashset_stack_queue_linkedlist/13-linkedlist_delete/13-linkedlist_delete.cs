using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || myLList.Count <= 0)
            return;
        if (index < 0 || index > myLList.Count)
            return;
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; current.Next != null; i++, current = current.Next)
            if (i == index)
            {
                myLList.Remove(current);
                return;
            }
        myLList.Remove(current);
    }
}
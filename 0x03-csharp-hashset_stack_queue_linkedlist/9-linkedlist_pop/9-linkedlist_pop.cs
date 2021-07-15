using System;
using System.Collections.Generic;
class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int value = 0;
        if (myLList.Count > 0)
        {
            value = myLList.First.Value;
            myLList.RemoveFirst();
        }
        return value;
    }
}
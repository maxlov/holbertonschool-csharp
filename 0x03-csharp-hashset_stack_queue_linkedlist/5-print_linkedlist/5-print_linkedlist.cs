﻿using System;
using System.Collections.Generic;

class LList
{
    // Main - entry point
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> llist = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            llist.AddLast(i);
            Console.WriteLine(i);
        }
        return llist;
    }
}
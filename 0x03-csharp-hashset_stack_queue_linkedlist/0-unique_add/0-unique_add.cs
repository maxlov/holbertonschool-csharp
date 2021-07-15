using System;
using System.Collections.Generic;

class List
{
    // Main - entry point
    public static int Sum(List<int> myList)
    {
        List<int> usedList = new List<int>();
        int total = 0;

        foreach (int value in myList)
            if (!usedList.Contains(value))
            {
                total += value;
                usedList.Add(value);
            }
        return total;
    }
}
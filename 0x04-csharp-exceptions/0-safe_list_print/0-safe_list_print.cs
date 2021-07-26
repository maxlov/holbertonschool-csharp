using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int number = 0;
        try
        {
            for (; number < n; number++)
                Console.WriteLine(myList[number]);
            return number;
        }
        catch (ArgumentOutOfRangeException)
        {
            return number;
        }
    }
}
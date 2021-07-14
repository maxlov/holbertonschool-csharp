using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> intList = new List<int>();
        for (int index = 0; index < size; index++)
            intList.Add(index);
        Console.WriteLine(String.Join(" ", intList));
        return intList;
    }
}
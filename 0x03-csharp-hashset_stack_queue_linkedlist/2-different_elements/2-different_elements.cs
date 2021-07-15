using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> diffList = new List<int>();

        foreach (int value in list1)
            if (!list2.Contains(value))
                diffList.Add(value);
        foreach (int value in list2)
            if (!list1.Contains(value))
                diffList.Add(value);
        diffList.Sort();
        return diffList;
    }
}
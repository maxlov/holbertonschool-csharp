using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keyList = new List<string>(myDict.Keys);
        keyList.Sort();
        foreach (var key in keyList)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}
﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        var count = 0;
        foreach (var key in myDict)
            count++;
        return count;
    }
}
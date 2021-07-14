using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string winner = "None";
        int best = -1;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > best)
            {
                winner = entry.Key;
                best = entry.Value;
            }
        }
        return winner;
    }
}
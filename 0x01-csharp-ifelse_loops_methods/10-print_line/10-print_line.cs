using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
        {
            Console.Write("\n");
            return;
        }
        Console.Write("_");
        PrintLine(length - 1);
    }
}
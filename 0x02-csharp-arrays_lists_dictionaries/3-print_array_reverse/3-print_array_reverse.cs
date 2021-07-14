using System;

class Array
{
    public static void Reverse(int[] array)
    {
        RecursiveReverse(array, 0);
        Console.Write("\n");
    }

    static void RecursiveReverse(int[] array, int idx)
    {
        if (array == null || idx == array.Length)
            return;
        RecursiveReverse(array, idx + 1);
        if (idx == 0)
            Console.Write(array[idx]);
        else
            Console.Write(array[idx] + " ");
        
    }
}
using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];
        for (int index = 0; index < size; index++)
        {
            newArray[index] = index;
            if (index == size - 1)
                Console.WriteLine(index);
            else
                Console.Write(index + " ");
        }
        if (size == 0)
            Console.WriteLine();
        return newArray;
    }
}
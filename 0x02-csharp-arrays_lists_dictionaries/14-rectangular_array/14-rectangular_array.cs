using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] rectangle = new int[5, 5];

        rectangle[2,2] = 1;

        for (int col = 0; col < rectangle.GetLength(0); col++)
            for (int row = 0; row < rectangle.GetLength(1); row++)
            {
                if (row == rectangle.GetLength(1) - 1)
                    Console.Write(rectangle[col,row] + "\n");
                else
                    Console.Write(rectangle[col,row] + " ");
            }
    }
}

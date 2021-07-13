using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.Write("\n");
            return;
        }
        for (var spaces = 0; spaces < length; spaces++) {
            for (var print_space = 0; print_space < spaces; print_space++)
                Console.Write(" ");
            Console.Write("\\\n");
        }
    }
}
using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
            number *= -1;
        while (number > 10)
                number %= 10;
        Console.Write(number);
        return number;
    }
}
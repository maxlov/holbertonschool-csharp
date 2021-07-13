using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "";
        for (var number = 0; number <= 100; number++)
        {
            text = "";
            if (number % 3 == 0)
                text += "Fizz";
            if (number % 5 == 0)
                text += "Buzz";
            if (text.Length == 0)
                text += number;
            if (number != 100)
                text += " ";
            Console.Write(text);
        }
    }
}

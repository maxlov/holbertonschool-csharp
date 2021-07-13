using System;

class Program
{
    static void Main(string[] args)
    {
        var end = ", ";
        for (var number = 0; number <= 99; number++)
        {
            if (number == 99)
                end = "\n";
            Console.Write($"{number:0#}{end}");
        }
    }
}

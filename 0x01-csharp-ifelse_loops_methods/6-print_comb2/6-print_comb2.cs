using System;

class Program
{
    static void Main(string[] args)
    {
        var end = ", ";
        for (var tens = 0; tens <= 8; tens++)
            for (var ones = tens + 1; ones <= 9; ones++)
            {
                if (tens == 8 && ones == 9)
                    end = "\n";
                Console.Write($"{tens}{ones}{end}");
            }
    }
}

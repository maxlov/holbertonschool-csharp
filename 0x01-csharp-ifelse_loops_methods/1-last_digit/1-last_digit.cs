using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int originalNumber = number;
        if (number < 0)
            while (number * -1 > 10)
                number %= 10;
        else
            while (number > 10)
                number %= 10;
        if (number > 5)
            Console.WriteLine($"The last digit of {originalNumber} is {number} and is greater than 5");
        else if (number == 0)
            Console.WriteLine($"The last digit of {originalNumber} is {number} and is 0");
        else
            Console.WriteLine($"The last digit of {originalNumber} is {number} and is less than 6 and not 0");
    }
}
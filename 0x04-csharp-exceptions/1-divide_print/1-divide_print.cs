using System;

class Int
{
    public static void divide(int a, int b)
    {
        int answer = 0;
        try
        {
            answer = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {answer}");
        }
    }
}
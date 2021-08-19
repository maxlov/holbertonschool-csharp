using System;

class Program
{
    static void Main(string[] args)
    {
		double[] vector = new double[] {3, 9};
		Console.WriteLine(String.Join(",", VectorMath.Multiply(vector, 2)));

		vector = new double[] {-3, -9, 7, 10}; 
		Console.WriteLine(String.Join(",", VectorMath.Multiply(vector, 2)));

		vector = new double[] {6, 11, 7}; 
		Console.WriteLine(String.Join(",", VectorMath.Multiply(vector, 2)));
    }
}
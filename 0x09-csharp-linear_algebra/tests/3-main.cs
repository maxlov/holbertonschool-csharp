using System;

class Program
{
    static void Main(string[] args)
    {
		double[] vector = new double[] {3, 9}; 
		Console.WriteLine(VectorMath.Magnitude(vector));

		vector = new double[] {-3, -9, 7}; 
		Console.WriteLine(VectorMath.Magnitude(vector));

		vector = new double[] {-3, -9, 7, 20}; 
		Console.WriteLine(VectorMath.Magnitude(vector));
    }
}
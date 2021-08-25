using System;

class Program
{
    static void Main(string[] args)
    {
		double[] vector1 = new double[] {1, 3}; 
		double[] vector2 = new double[] {-2, 5}; 
		Console.WriteLine(String.Join(",", VectorMath.CrossProduct(vector1, vector2)));

		vector1 = new double[] {-2, -2, 1}; 
		vector2 = new double[] {-8, 8, -4}; 
		Console.WriteLine(String.Join(",", VectorMath.CrossProduct(vector1, vector2)));
    }
}
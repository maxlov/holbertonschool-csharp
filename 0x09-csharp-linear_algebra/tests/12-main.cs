using System;

class Program
{
    static void Main(string[] args)
    {
		double[] vector1 = new double[] {1, 3}; 
		double[] vector2 = new double[] {-2, 5}; 
		Console.WriteLine(VectorMath.DotProduct(vector1, vector2));

		vector1 = new double[] {3, 7, -9}; 
		Console.WriteLine(VectorMath.DotProduct(vector1, vector2));

		vector2 = new double[] {-4, 0, 10}; 
		Console.WriteLine(VectorMath.DotProduct(vector1, vector2));
    }
}
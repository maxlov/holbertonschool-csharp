using System;

class Program
{
    static void Main(string[] args)
    {
		double[] vector1 = new double[] {3, 9}; 
		double[] vector2 = new double[] {7, -1}; 
		Console.WriteLine(String.Join(",", VectorMath.Add(vector1, vector2)));

		vector1 = new double[] {-3, -9, 7}; 
		Console.WriteLine(String.Join(",", VectorMath.Add(vector1, vector2)));

		vector2 = new double[] {6, 11, 7}; 
		Console.WriteLine(String.Join(",", VectorMath.Add(vector1, vector2)));
    }
}
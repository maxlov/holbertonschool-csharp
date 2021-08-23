using System;

class Program
{
    static void Main(string[] args)
    {
		double[,] matrix = new double[,] { { 14, -3 }, { -11, -5 } };
		double scalar = 4;

		printMatrix(MatrixMath.MultiplyScalar(matrix, scalar));

		matrix = new double[,] { { 14, -3, 0 }, { -11, -5, 3 } };
		printMatrix(MatrixMath.MultiplyScalar(matrix, scalar));

		matrix = new double[,] { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };
		printMatrix(MatrixMath.MultiplyScalar(matrix, scalar));
    }

	static void printMatrix(double[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			Console.Write("(");
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i,j] + ",");
			Console.WriteLine("),");
		}
		Console.WriteLine();
	}
}
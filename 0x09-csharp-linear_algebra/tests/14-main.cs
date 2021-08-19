using System;

class Program
{
    static void Main(string[] args)
    {
		double[,] matrix1 = new double[,] { { 14, -3 }, { -11, -5 } };
		double[,] matrix2 = new double[,] { { 6, 16 }, { 5, 2 } };

		printMatrix(MatrixMath.Add(matrix1, matrix2));

		matrix1 = new double[,] { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
		printMatrix(MatrixMath.Add(matrix1, matrix2));

		matrix2 = new double[,] { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };
		printMatrix(MatrixMath.Add(matrix1, matrix2));
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
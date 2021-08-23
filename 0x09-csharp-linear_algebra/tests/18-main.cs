using System;

class Program
{
    static void Main(string[] args)
    {
		double[,] matrix1 = new double[,] { { 2, 3 }, { -1, 0 } };
		double[,] matrix2 = new double[,] { { 1, 7 }, { -8, -2 } };

		printMatrix(MatrixMath.Multiply(matrix1, matrix2));

		matrix1 = new double[,] { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
		printMatrix(MatrixMath.Multiply(matrix1, matrix2));

		matrix2 = new double[,] { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };
		printMatrix(MatrixMath.Multiply(matrix1, matrix2));

		matrix1 = new double[,] { { 0, 3, 5 }, { 5, 5, 2 } };
		matrix2 = new double[,] { { 3, 4 }, { 3, -2 }, { 4, -2 } };
		printMatrix(MatrixMath.Multiply(matrix1, matrix2));
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
using System;

class Program
{
    static void Main(string[] args)
    {
		double[,] matrix = new double[,] { { 1, 2 }, { 3, 4 } };

		printMatrix(MatrixMath.Shear2D(matrix, 'x', 2));

		matrix = new double[,] { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
		printMatrix(MatrixMath.Shear2D(matrix, 'y', 20));
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
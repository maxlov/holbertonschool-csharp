using System;

/// <summary>Class holding methods that perform Matrix operations.</summary>
class MatrixMath
{
    /// <summary>Calculates product of vectors.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };

        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        int i, j, k;
        int row = result.GetLength(0);
        int col = result.GetLength(1);

        for (i = 0; i < row; i++)
            for (j = 0, result[i, j] = 0; j < col; j++)
                for (k = 0; k < matrix1.GetLength(1); k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];

        return result;
    }
}

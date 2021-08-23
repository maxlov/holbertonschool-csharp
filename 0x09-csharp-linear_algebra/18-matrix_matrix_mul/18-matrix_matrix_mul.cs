using System;

/// <summary>Class holding methods that perform Matrix operations.</summary>
class MatrixMath
{
    /// <summary>Calculates product of vectors.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0))
            return new double[,] { { -1 } };

        if (matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3)
            return new double[,] { { -1 } };
        
        if (matrix1.GetLength(1) != matrix2.GetLength(1))
            return new double[,] { { -1 } };

        if (matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3 || matrix1.GetLength(1) != matrix1.GetLength(0))
            return new double[,] { { -1 } };

        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        int N = matrix1.GetLength(0);

        int i, j, k;
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < N; j++)
            {
                result[i, j] = 0;
                for (k = 0; k < N; k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }

        return result;
    }
}

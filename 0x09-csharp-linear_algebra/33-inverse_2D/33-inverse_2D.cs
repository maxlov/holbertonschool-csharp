using System;

/// <summary>Class holding methods that perform Matrix operations.</summary>
class MatrixMath
{
    /// <summary>Calculates inverse of 2D matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double determinant = Math.Round(matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0], 2);

        if (determinant == 0)
            return new double[,] { { -1 } };

        double[,] identity = new double[,] {{ 1, 0 }, { 0, 1 } };
        double[,] result = new double[2, 2];

        result[0, 0] = Math.Round(matrix[1,1] / determinant, 2);
        result[0, 1] = Math.Round(-matrix[0,1] / determinant, 2);
        result[1, 0] = Math.Round(-matrix[1,0] / determinant, 2);
        result[1, 1] = Math.Round(matrix[0,0] / determinant, 2);

        return result;
    }
}

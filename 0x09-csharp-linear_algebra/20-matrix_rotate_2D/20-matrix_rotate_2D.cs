using System;

/// <summary>Class holding methods that perform Matrix operations.</summary>
class MatrixMath
{
    /// <summary>Calculates rotation of matrix.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double[,] result = new double[2, 2];
        double[,] rotation = new double[,] {
            { Math.Cos(angle) , Math.Sin(angle) },
            { -Math.Sin(angle), Math.Cos(angle) } };

        int i, j, k;

        for (i = 0; i < 2; i++)
            for (j = 0, result[i, j] = 0; j < 2; j++)
            {
                for (k = 0; k < 2; k++)
                    result[i, j] += matrix[i, k] * rotation[k, j];
                result[i, j] = Math.Round(result[i, j], 2);
            }
        return result;
    }
}

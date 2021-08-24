using System;

/// <summary>Class holding methods that perform Matrix operations.</summary>
class MatrixMath
{
    /// <summary>Calculates shear of matrix.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double[,] shear = new double[2,2];
        if (direction == 'x')
            shear = new double[,] { { 1, 0 }, { factor, 1 } };
        else if (direction == 'y')
            shear = new double[,] { { 1, factor }, { 0, 1 } };
        else
            return new double[,] { { -1 } };

        double[,] result = new double[2, 2];

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    result[i, j] = Math.Round(result[i, j] + matrix[i, k] * shear[k, j], 2);
        return result;
    }
}

using System;

/// <summary>Class holding methods that perform Matrix operations.</summary>
class MatrixMath
{
    /// <summary>Transposes a matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return new double[,] { { } };

        int oldRow =  matrix.GetLength(0);
        int oldCol = matrix.GetLength(1);

        double[,] result = new double[oldCol, oldRow];

        for (int i = 0; i < oldRow; i++)
            for (int j = 0; j < oldCol; j++)
                result[j, i] = matrix[i, j];
        return result;
    }
}

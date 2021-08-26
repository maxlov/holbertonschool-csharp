using System;

/// <summary>Class holding methods that perform Matrix operations.</summary>
class MatrixMath
{
    /// <summary>Calculates matrix determinant.</summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
           return Math.Round(matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0], 2);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double a = Math.Round(matrix[0,0] * (matrix[1,1] * matrix[2,2] - matrix[1,2] * matrix[2,1]), 2);
            double b = Math.Round(matrix[0,1] * (matrix[1,0] * matrix[2,2] - matrix[1,2] * matrix[2,0]), 2);
            double c = Math.Round(matrix[0,2] * (matrix[1,0] * matrix[2,1] - matrix[2,2] * matrix[2,0]), 2);
            return Math.Round(a - b + c, 2);
        }
        return -1;
    }
}

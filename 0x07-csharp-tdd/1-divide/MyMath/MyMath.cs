using System;

namespace MyMath
{
    /// <summary>Matrix class holding methods that operate on matrices.</summary>
    public class Matrix
    {
        /// <summary>Divides all elements of a matrix by num.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int [,] result = (int[,])matrix.Clone();
            for (int row = 0; row < result.GetLength(0); row++)
                for (int idx = 0; idx < result.GetLength(1); idx++)
                    result[row, idx] /= num;
            return result;
        }
    }
}

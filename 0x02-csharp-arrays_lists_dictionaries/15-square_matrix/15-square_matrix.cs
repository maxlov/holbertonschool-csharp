using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        for (int col = 0; col < myMatrix.GetLength(0); col++)
            for (int row = 0; row < myMatrix.GetLength(1); row++)
                myMatrix[col,row] *= myMatrix[col,row];
        return myMatrix;
    }
}
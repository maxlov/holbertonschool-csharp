using System;

/// <summary>Class holding methods that perform Vector operations.</summary>
class VectorMath
{
    /// <summary>Calculates dot product of vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return -1;
        if (vector1.Length < 2 || vector1.Length > 3)
            return -1;

        double result = 0;
        
        for (int i = 0; i < vector1.Length; i++)
            result += vector1[i] * vector2[i];

        return result;
    }
}

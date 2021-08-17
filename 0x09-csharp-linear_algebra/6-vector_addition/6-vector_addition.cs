using System;

/// <summary>Class holding methods that perform Vector operations.</summary>
class VectorMath
{
    /// <summary>Calculates sum of vectors.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return new double[] {-1};
        if (vector1.Length < 2 || vector1.Length > 3)
            return new double[] {-1};

        double[] result = new double[vector1.Length];
        
        for (int i = 0; i < vector1.Length; i++)
            result[i] = vector1[i] + vector2[i];

        return result;
    }
}

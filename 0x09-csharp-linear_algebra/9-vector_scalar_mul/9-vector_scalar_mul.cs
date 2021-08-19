using System;

/// <summary>Class holding methods that perform Vector operations.</summary>
class VectorMath
{
    /// <summary>Calculates vector scalar multiplication</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return new double[] {-1};
        
        for (int i = 0; i < vector.Length; i++)
            vector[i] *= scalar;

        return vector;
    }
}

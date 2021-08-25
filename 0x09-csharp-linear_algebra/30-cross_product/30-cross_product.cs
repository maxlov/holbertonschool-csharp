using System;

/// <summary>Class holding methods that perform Vector operations.</summary>
class VectorMath
{
    /// <summary>Calculates cross product of vectors.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length != 3)
            return new double[] { -1 };

        double[] result = new double[3];
        
        result[0] = Math.Round(vector1[1] * vector2[2] - vector1[2] * vector2[1], 2);
        result[1] = Math.Round(vector1[2] * vector2[0] - vector1[0] * vector2[2], 2);
        result[2] = Math.Round(vector1[0] * vector2[1] - vector1[1] * vector2[0], 2);

        return result;
    }
}

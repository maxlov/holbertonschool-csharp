using System;

/// <summary>Class holding methods that perform Vector operations.</summary>
class VectorMath
{
    /// <summary>Calculates magintude of vector.</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return -1;

        double magnitude = 0;
        foreach (double value in vector)
            magnitude += Math.Pow(value, 2.0);

        return Math.Round(Math.Sqrt(magnitude), 2);
    }
}

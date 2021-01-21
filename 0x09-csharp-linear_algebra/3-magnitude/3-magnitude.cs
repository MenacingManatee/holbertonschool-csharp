using System;

/// <summary>
/// VectorMath class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Finds the magnitude of a 2d or 3d vector
    /// </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2));
        }
        if (vector.Length == 3)
        {
            return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2));
        }
        return (-1);
    }
}

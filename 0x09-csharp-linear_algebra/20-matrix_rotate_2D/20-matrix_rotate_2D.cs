using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds 2 2d or 3d matrices
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int i = 0;
        double[,] res = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            for (i = 0; i < 2; i++)
            {
                res[i, 0] = (matrix[i, 0] * Math.Cos(angle)) - (matrix[i, 1] * Math.Sin(angle));
                res[i, 1] = (matrix[i, 0] * Math.Sin(angle)) + (matrix[i, 1] * Math.Cos(angle));
            }
            return (res);
        }
        return (new double[,] {{-1}});
    }
}

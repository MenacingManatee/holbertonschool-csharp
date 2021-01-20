using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds 2 2d or 3d matrices
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int i = 0, j = 0;
        double[,] res = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    res[i, j] = matrix[i, j] * scalar;
                }
            }
            return (res);
        }
        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    res[i, j] = matrix[i, j] * scalar;
                }
            }
            return (res);
        }
        return (new double[,] {{-1}});
    }
}

using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transposes a matrix
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int i = 0, j = 0;
        double[,] res = new double[matrix.GetLength(1), matrix.GetLength(0)];

        if (matrix.Length > 0)
        {
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    res[j, i] = matrix[i, j];
                }
            }
        }
        return (res);
    }
}

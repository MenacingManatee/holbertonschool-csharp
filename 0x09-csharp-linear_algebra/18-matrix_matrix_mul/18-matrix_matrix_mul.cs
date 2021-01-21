using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds 2 2d or 3d matrices
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int i = 0, i2 = 0, j = 0;
        double tmp = 0;
        int l = Math.Min(matrix1.GetLength(0), matrix1.GetLength(1));
        double[,] res = new double[l, l];

        if (matrix1.GetLength(0) == matrix2.GetLength(1) && matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            for (i = 0; i < matrix1.GetLength(0); i++)
            {
                for (i2 = 0; i2 < matrix1.GetLength(0); i2++)
                {
                    for (j = 0; j < matrix1.GetLength(1); j++)
                    {
                        tmp += matrix1[i, j] * matrix2[j, i2];
                    }
                    res[i, i2] = Math.Round(tmp, 2);
                    tmp = 0;
                }
            }
            return (res);
        }
        return (new double[,] {{-1}});
    }
}

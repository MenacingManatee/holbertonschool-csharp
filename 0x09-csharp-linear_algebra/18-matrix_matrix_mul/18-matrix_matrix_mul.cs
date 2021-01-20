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
        double[,] res = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
        {
            for (i = 0; i < 2; i++)
            {
                for (i2 = 0; i2 < 2; i2++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        tmp += matrix1[i, j] * matrix2[j, i2];
                    }
                    res[i, i2] = tmp;
                    tmp = 0;
                }
            }
            return (res);
        }
        if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
        {
            for (i = 0; i < 3; i++)
            {
                for (i2 = 0; i2 < 3; i2++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        tmp += matrix1[i, j] * matrix2[j, i2];
                    }
                    res[i, i2] = tmp;
                    tmp = 0;
                }
            }
            return (res);
        }
        return (new double[,] {{-1}});
    }
}

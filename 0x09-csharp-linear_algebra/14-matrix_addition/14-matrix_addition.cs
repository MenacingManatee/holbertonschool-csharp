using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds 2 2d or 3d matrices
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int i = 0, j = 0;
        double[,] res = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
        {
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    res[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return (res);
        }
        if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    res[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return (res);
        }
        return (new double[,] {{-1}});
    }
}
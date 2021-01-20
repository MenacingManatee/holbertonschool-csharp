using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Shears a 2D matrix in given direction
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int i = 0;
        double[,] res = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            if (direction == 'x')
            {
                for (i = 0; i < 2; i++)
                {
                    res[i, 0] = matrix[i, 0] + (factor * matrix[i, 1]);
                    res[i, 1] = matrix[i, 1];
                }
                return (res);
            }
            else if (direction == 'y')
            {
                for (i = 0; i < 2; i++)
                {
                    res[i, 0] = matrix[i, 0];
                    res[i, 1] = matrix[i, 1] + (factor * matrix[i, 0]);
                }
                return (res);
            }
            else
            {
                return (new double[,] {{-1}});
            }
        }
        return (new double[,] {{-1}});
    }
}

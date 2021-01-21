using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transposes a matrix
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        double res;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        }
        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            res = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[1, 2]));
            res -= matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]));
            res += matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
            return (res);
        }
        return (-1);
    }
}

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
        double[,] res = new double[2, 2];

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            if (determinant == 0)
                return (new double[,] {{-1}});
            res[0, 0] = Math.Round(matrix[1, 1] * (1 / determinant), 2);
            res[1, 1] = Math.Round(matrix[0, 0]* (1 / determinant), 2);
            res[0, 1] = Math.Round((matrix[0, 1] * -1) * (1 / determinant), 2);
            res[1, 0] = Math.Round((matrix[1, 0] * -1) * (1 / determinant), 2);
            return (res);
        }
        return (new double[,] {{-1}});
    }
}

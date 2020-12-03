using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int l1 = myMatrix.GetLength(0);
        int l2 = myMatrix.GetLength(1);
        int[,] m = new int[l1, l2];
        int i;
        int j;

        for (i = 0; i < l1; i++)
        {
            for (j = 0; j < l2; j++)
            {
                m[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return m;
    }
}

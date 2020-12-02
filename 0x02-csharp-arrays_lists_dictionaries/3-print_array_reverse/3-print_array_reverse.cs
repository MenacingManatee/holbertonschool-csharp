using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.Write("\n");
            return;
        }
        int i = array.Length - 1;
        string sep = " ";
        for (; i >= 0; i--)
        {
            if (i == 0)
                sep = "\n";
            Console.Write("{0}{1}", array[i], sep);
        }
    }
}

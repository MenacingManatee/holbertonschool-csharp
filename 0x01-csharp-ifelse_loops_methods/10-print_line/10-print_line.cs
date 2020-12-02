using System;

class Line
{
    public static void PrintLine(int length)
    {
        int i;
        string res = "";
        if (length > 0)
        {
            for (i = 0; i < length; i += 1)
                res += '_';
        }
        Console.WriteLine(res);
    }
}

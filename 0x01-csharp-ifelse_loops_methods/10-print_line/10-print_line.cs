using System;

/// Line class
class Line
{
    /// Prints an input number of the character '_'
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

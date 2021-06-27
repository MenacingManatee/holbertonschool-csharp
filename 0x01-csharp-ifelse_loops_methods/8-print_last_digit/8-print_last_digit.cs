using System;

class Number
{
    /// Prints the last digit of an int
    public static int PrintLastDigit(int number)
    {
        int l = Math.Abs(number % 10);
        Console.Write("{0}", l);
        return l;
    }
}

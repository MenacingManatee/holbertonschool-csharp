using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int l = Math.Abs(number % 10);
        Console.Write("{0}", l);
        return l;
    }
}

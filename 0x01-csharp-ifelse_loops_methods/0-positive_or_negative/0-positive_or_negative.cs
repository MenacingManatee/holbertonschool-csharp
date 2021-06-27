using System;

class Program
{
    /// Generates a random number, then determines its sign
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if (number > 0)
            Console.WriteLine("{0} is positive", number);
        else if (number < 0)
            Console.WriteLine("{0} is negative", number);
        else
            Console.WriteLine("{0} is zero", number);
    }
}

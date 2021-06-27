using System;

class Program
{
    /// Generates a random number, then pulls its last digit
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int ld = number % 10;
        if (ld > 5)
            Console.WriteLine("The last digit of {0} is {1} and is greater than 5", number, ld);
        else if (ld < 6 && ld != 0)
            Console.WriteLine("The last digit of {0} is {1} and is less than 6 and not 0", number, ld);
        else
            Console.WriteLine("The last digit of {0} is {1} and is 0", number, ld);
    }
}

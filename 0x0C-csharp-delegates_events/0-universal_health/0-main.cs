using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 500f);
        Player player2 = new Player("Water Turtle");

        player1.PrintHealth();
        player2.PrintHealth();
        Player player3 = new Player("Turducken", 0f);
        player3.PrintHealth();
    }
}

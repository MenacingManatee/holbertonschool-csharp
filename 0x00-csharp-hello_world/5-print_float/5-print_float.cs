using System;

class Program
{
	/// Writes a float to the console using string formatting and precision
	static void Main(string[] args)
	{
		float number = 3.14159f;
		Console.WriteLine("Float: {0:F2}", number);
	}
}

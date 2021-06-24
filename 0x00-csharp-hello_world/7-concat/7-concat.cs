using System;

class Program
{
	/// Writes a string to the console using concatenation
	static void Main(string[] args)
	{
		string str1 = "Holberton";
		string str2 = "School";
		str1 = str1 + " " + str2;
		Console.WriteLine("Welcome to {0}!", str1);
	}
}

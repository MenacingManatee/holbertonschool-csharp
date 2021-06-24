using System;

class Program
{
	/// Writes a prebuilt string to the console using substrings
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine("{0}{0}{0}\n{1}", str, str.Substring(0, 9));
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string[] names = new string[] { "Joe", "James", "Bill", "Sally", "Jill", "Jane", "Larry", "Lacy" };

		// Named method
		IEnumerable<string> name = names.Where(StartsWithL);
		foreach (string str in name)
		{
			Console.WriteLine(str);
		}

		// Anonymous method
		IEnumerable<string> nameAnonymous =
			names.Where(delegate (string s)
			{ return s.StartsWith("L"); });


		// Lambda expression
		IEnumerable<string> nameLambda =
			names.Where(s => s.StartsWith("L"));

	}

	public static bool StartsWithL(string name)
	{
		return name.StartsWith("L");
	}

}
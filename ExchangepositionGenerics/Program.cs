using System;

namespace ExchangepositionGenerics
{
	using System;

	public class Program
	{
		public static void Main()
		{
			//string monday = "Monday";

			string[] daysOfWeek = new string[7] {
			"Sunday",
			"Monday",
			"Tuesday",
			"Wednesday",
			"Thrusday",
			"Friday",
			"Saturday"
		};

			Console.WriteLine("For loop: ");
			for (int i = 0; i < 7; i++)
			{
				Console.WriteLine(daysOfWeek[i]);
			}

			Console.WriteLine("Foreach: ");
			foreach (var item in daysOfWeek)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Select by Index: ");
			Console.WriteLine(daysOfWeek[2]);

			Console.WriteLine("Replace by Index: ");
			Console.WriteLine(Replace);

			Console.WriteLine("Request an index outside the bounds of the Array:");
			Console.WriteLine();

		}
	}

}

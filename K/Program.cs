
using System;
using System.Linq;

namespace K
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	public class Program
	{
		public static void Main()
		{
			// Where example
			string[] strings = new string[]{"one", "two", "three","four",
										"five", "six", "seven", "eight", "nine", "ten"};

			// public static IEnumerable<TSource>
			//		Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
			IEnumerable<string> results = strings.Where(
				s =>
				s.StartsWith("f") && s.EndsWith("r"));

			foreach (var str in results)
				Console.WriteLine(str);



			System.Collections.ArrayList fruits = new System.Collections.ArrayList(4);
			fruits.Add("Mango");
			fruits.Add("Orange");
			fruits.Add("Apple");
			fruits.Add(3.0);
			fruits.Add("Banana");

			// Apply OfType() to the ArrayList.
			// public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source);
			IEnumerable<string> query1 = fruits.OfType<string>();

			Console.WriteLine("Elements of type 'string' are:");
			foreach (string fruit in query1)
			{
				Console.WriteLine(fruit);
			}


		}
	}
}

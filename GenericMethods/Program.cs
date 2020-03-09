using System;
using System.Collections.Generic;
namespace GenericMethods
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Collections.Specialized;

	
	public class Program
	{
		public static void Main()
		{
			Dictionary<string, Book> books = new Dictionary<string, Book>();
			books.Add("Joe", new Book("Essential C# 4.0", 2013));
			books.Add("Jane", new Book("Visual C Sharp 2012 Step by Step", 2014));
			books.Add("Mindy", new Book("Professional C 2012 and .NET 4.5", 2014));

			foreach (var book in books)
				Console.WriteLine("{0} {1}", book.Key,book.Value);

			foreach (var book in books)
				Console.WriteLine(book.Value);

			foreach (var book in books)
				Console.WriteLine(book.Key);

			// looking up items
			Book book1 = books["Joe"];

			// contains key
			books.ContainsKey("Joe");

			// replace value
			books["Joe"] = new Book("How to Code", 2012);

			foreach (var book in books)
				Console.WriteLine(book.ToString());

		}
	}

	public class Book
	{
		public string Name { get; set; }

		public int Year { get; set; }

		public Book(string Name, int Year)
		{
			this.Name = Name;
			this.Year = Year;
		}

	}

	public 
}
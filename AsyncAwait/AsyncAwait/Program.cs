using System;

namespace AsyncAwait
{
   using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		CallerWithAsyn();
		Console.WriteLine("Called CallerWithAsync");
		Console.ReadLine();
	}

	private async static void CallerWithAsyn()
	{
		string result = await GreetingAsync("Stephanie");
		Console.WriteLine(result);
	}

	private static Task<string> GreetingAsync(string name)
	{
		return Task.Run<string>(() => Greeting(name));
	}

	private static string Greeting(string name)
	{
		Thread.Sleep(3000);
		return string.Format("Hello, {0}", name);
	}
}
}

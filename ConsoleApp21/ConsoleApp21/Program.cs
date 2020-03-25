using System;

namespace ConsoleApp21
{
	using System;



	public class Program
	{

		public static void Main()
		{
			int sum = 0;
			Console.WriteLine("ENter string");
			string input = Console.ReadLine();
			String[] inputsplit = input.Split('+');
			int y = 0;
			for(int i=0;i<inputsplit.Length;i++)
			{
				if (int.TryParse(inputsplit[i], out y))
				{
					sum = sum + y;
				}
			}
			Console.WriteLine("The value of sum={0}", sum);

		}
	}
}
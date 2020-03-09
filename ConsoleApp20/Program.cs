using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp20
{

	public class Program
	{

		static object taskMethodLock = new object();

		public static void Main()
		{
			var t1 = new Task(TaskMethod, "Run Task");
			t1.Start();

			Task t = Task.Factory.StartNew(() =>
			{
				TaskMethod("Run Factory");
			});
			Console.ReadLine();
		}

		static void TaskMethod(object title)
		{
			lock (taskMethodLock)
			{
				Console.WriteLine(title);
				Console.WriteLine("Task id: {0}, thread: {1}",
								  Task.CurrentId == null ? "no task" : Task.CurrentId.ToString(),
								  Thread.CurrentThread.ManagedThreadId);
				Console.WriteLine("is pooled thread: {0}",
								  Thread.CurrentThread.IsThreadPoolThread);
				Console.WriteLine("is background thread: {0}",
								  Thread.CurrentThread.IsBackground);
				Console.WriteLine();
			}
		}
	}
}

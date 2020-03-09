using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
          ParallelLoopResult result = Parallel.For(0, 10, i =>
		{
			Console.WriteLine("{0}, task: {1}, thread: {2}", i, Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
			//Thread.Sleep(10);
		}

		);
		Console.WriteLine("Is completed: {0}", result.IsCompleted);
		//Console.ReadLine();
        }
    }
}

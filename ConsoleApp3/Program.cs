using System;

namespace ConsoleApp3
{
	using System;
	using System.Collections.Generic;

	public class Program
	{
		public static void Main()
		{
			var dQueue = new DocumentManager<string>();

			dQueue.AddDocument("1");

			dQueue.GetDocument();

		}
	}

	public class DocumentManager<T>
	{
		private readonly Queue<T> documentQueue = new Queue<T>();

		public void AddDocument(T doc)
		{
			documentQueue.Enqueue(doc);
		}

		public bool IsDocumentAvailable
		{
			get
			{
				return documentQueue.Count > 0;
			}
		}

		public T GetDocument()
		{
			T doc = default;
			Console.WriteLine("Default value of Document is {0}", (doc != null) ? doc.ToString() : "null");
			doc = documentQueue.Dequeue();

			return doc;
		}
	}
}

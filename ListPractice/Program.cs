using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListPractice
{
    class Program : Collection<string>
    {
        static void Main(string[] args)
        {
            List<string> newlist = new List<string> { "Hello", "Hi", "Byee" };
            Console.WriteLine("");
            Console.WriteLine("Before Adding");
            writetoconsole<string>(newlist);
            Console.WriteLine("");
            Console.WriteLine("After Adding");
            newlist.Add("New element");
            writetoconsole<string>(newlist);
            Console.WriteLine("");
            Console.WriteLine("After removing");
            newlist.Remove("hi");
            newlist.RemoveAt(1);
            writetoconsole<string>(newlist);


        }



        public static void writetoconsole<T>(List<T> lt)
        {
            foreach (var item in lt)
            {
                Console.WriteLine(item);
            }
        }
    }


    public class MyCustomCollection : IList<T>
    {
        // Override the InsertItem method from Collection 
        //   and throw an error if the string being added is Null or Empty
        protected override void Insert(int index, T item)
        {
            // check if the item being added is null or empty
            if (string.IsNullOrEmpty(item))
            {
                throw new Exception("Item inserted into collection cannot be null.");
            }

            // perform the Collection classes InsertItem method
            base.Insert(index, item);
        }

    }
}
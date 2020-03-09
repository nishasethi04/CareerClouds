using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
 
    }
    public class SomeCollection : IEnumerable
    {
        private List<T> _mylist;




        public SomeCollection()
        {
            _mylist = new List<T>();
        }

        public void Add(T item)
        {
            _mylist.Add(item);
        }

        public void Get(int pos)
        {
            return _mylist[pos];
        }

        public IEnumerator<T> GetEnumerator()
        {

        }

    }

}

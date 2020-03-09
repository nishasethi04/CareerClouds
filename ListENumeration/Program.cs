using System;
using System.Collections.Generic;

namespace ListENumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> _ints = new List<int>() { 1, 2, 3 };
            foreach(var x in _ints)
            {
                _ints.Add(x);
                Console.WriteLine(x);
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionaryofints = new Dictionary<int, int>() { { 1, 2 }, { 2, 2 }, { 3, 3 } };
            foreach(var item in dictionaryofints)
            {
                Console.WriteLine("Key is{0} and value is {1}",item.Key,item.Value );
            }

        }
    }
}

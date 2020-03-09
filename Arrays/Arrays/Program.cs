using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[] { 10, 20, 30, 20, 3 };
            foreach (int z in a)
            {
                Console.WriteLine(z);
                           }
            int[][] jag = new int[3][];
           jag[0] = new int[3] { 10, 20, 30 };
            jag[1] = new int[2] { 10, 20 };
            foreach(int d in jag)
            {
                Console.WriteLine(d);

            }
            
        }

    }
}
using System;

namespace PracticeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of elements");
            string s;
            int n;
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            Console.WriteLine("{0}", n);
            Console.WriteLine("Enter String");
            string ar;
            ar = Console.ReadLine();
            string[] a = ar.Split(' ');
            int sum = 0;
            for(int x=0;x<a.Length;x++ )
            {
                int number = int.Parse(a[x]);
                sum += number;
            }
            Console.WriteLine("{0}",sum);
        }
    }
}

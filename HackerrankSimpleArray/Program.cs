using System;
using System.Linq;

namespace HackerrankSimpleArray
{
    class Program
    {
        public static int sumarray(int []arr)
        {
            int tot=0;
            for (int i = 0; i < arr.Length; i++)
                tot += arr[i];
            return tot;
        }

        public static void Main(string[] args)
        {
            
            int n;
            Console.WriteLine("Enter number of elements in an array");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of array");

            int[] ar = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray(); 
            int sum = sumarray(ar);
            Console.WriteLine("The sum of array={0}",sum );

        }
    }
}

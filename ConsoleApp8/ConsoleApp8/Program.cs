using System;

namespace ConsoleApp8
{
    class Program
    {

        public static void Main()
        {
            int i = 0;
            int[] ints = { 0, 1, 2, 4, 8 };

            // Display the original values.
            Console.WriteLine("i = " + i);
            Console.WriteLine("ints[0] = " + ints[0]);
            Console.WriteLine("\nCalling SomeFunction. ..");

            // After this method returns, ints will be changed,
            // but i will not.
            SomeFunction(ints, i);
            Console.WriteLine("i = " + i);
            Console.WriteLine("ints[0] = " + ints[0]);

            Console.WriteLine("\nCalling SomeFunction .. out");
            SomeFunction(out i);
            Console.WriteLine(i);
        }

        static void SomeFunction(int[] ints, int i)
        {
            ints[0] = 100;
            i = 100;
        }

        static void SomeFunction(int[] ints, ref int i)
        {
            ints[0] = 100;
            i = 100; // The change to i will persist after SomeFunction() exits.
        }

        // SomeFunction with an out parameter
        static void SomeFunction(out int i)
        {
            i = 100;
        }

    }
}

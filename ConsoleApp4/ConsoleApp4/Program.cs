using System;

namespace ConsoleApp4
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int z;
            float b = 10.55F;
            int c = 10;
            String s = "100ghj";
                 bool str = int.TryParse(s, out int u);
            Console.WriteLine("String to int={0}", u);

            Console.WriteLine((int)(b + c));

            // i is initialized to 0
            // the for loop iterates while i is less than 100
            // i is incremented by 10 every loop
            for (int i = 0; i < 100; i += 10)
            {

                // if i is evenly divided by 3 then continue
                if (i % 3 == 0)
                {
                    Console.WriteLine("i divided by 3 remainder = 0 continue");
                    continue;
                }

                // j is initialized to i
                // the for loop iterates while j is less than i + 10
                // j is incremented by 1 every loop
                for (int j = i; j < i + 10; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();

            }
        }
    }
}
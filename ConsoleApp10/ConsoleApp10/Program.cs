using System;

namespace ConsoleApp10
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter radious for circle");
            double radious = Convert.ToDouble(Console.ReadLine());
            double circumference = CalculateCircle(radious, out double area);
            Console.WriteLine("Circle's circumference is {0}",circumference);
            Console.WriteLine("Circle's Area is {0}",area);
            Console.WriteLine("Circle's Area is {0}",area);
            int z = Foo(10);
            Console.WriteLine(z);
            Console.ReadLine();
        }

        static double CalculateCircle(double radious, out double area)
        {
            area = Math.PI * Math.Pow(radious, 2);
            double circumference = 2 * Math.PI * radious;
            return circumference;
        }
        static int Foo(int x) => x * 2;
        

        

    }

}

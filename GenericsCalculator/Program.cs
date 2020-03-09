using System;

namespace GenericsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Genericspractice<float> gen = new Genericspractice<float>();
            Console.WriteLine(gen.add(10, 20));
            Console.WriteLine(gen.sub(20, 10));
            Console.WriteLine(gen.mul(10, 20));
            Console.WriteLine(gen.div(20, 10)); 
        }
    }
    
    public class Genericspractice<T>
    {
        public T add(T a, T b)
        {
            dynamic  x = a;
            dynamic y = b;
            return (x + y);

        }
        public T sub(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (x - y);

        }
        public T mul(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (x * y);

        }
        public T div(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (x / y);

        }

    }
}

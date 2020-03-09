using System;

namespace Genericspractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> obj = new GenericList<int>();
            GenericList<string> obj1 = new GenericList<string>();
            obj1.Add("Hi");
            obj1.Add("Hello");

            obj.Add(3);
            obj.Add(2);
            Console.WriteLine(obj.Get());
            Console.WriteLine( obj.Get());
            Console.WriteLine(obj1.Get());
            Console.WriteLine(obj1.Get());
        }
    }
public class GenericList<T>
    {
        T[] somelist =new T[10];
        int index = default;

        int getposition = 0;

        public void Add(T item)
        {
            Console.WriteLine("Default value={0}", index);
            somelist[index] = item;
            index++;

        }

        public T Get()
        {
            T item = somelist[getposition];
            getposition++;
            
            return item;
        }
    }



}

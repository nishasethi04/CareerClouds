using System;

namespace ConsoleApp12
{

    public class Program
    {
        public static void Main()
        {
            MyClass cls = new MyClass();
            cls.print();
        }


        interface IMyInterface
        {
            void DoSomething()
            {
                Console.WriteLine("Do Something.");

            }
        }

        class MyClass : IMyInterface
        {
            public void print()
            {
                Console.WriteLine("Class ");
            }
        }



    }
}

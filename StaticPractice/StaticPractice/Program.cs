using System;

namespace StaticPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMployee no={0}",Employee1.EmpNo);
            Employee1.Add();
        }
        static class Employee1
        {
            public static int EmpNo;
            static Employee1()
            {
                EmpNo = 10;
                // perform initialization here
            }
            public static void Add()
            {
                Console.WriteLine("EMployee no={0}", Employee1.EmpNo);
                Console.WriteLine("Add");
            }
            public static void Add1()
            {
                Console.WriteLine("Add1");
            }
        }
        }
    }


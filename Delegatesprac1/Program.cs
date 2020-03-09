using System;

namespace Delegatesprac1

{
    class Program
    {
        public delegate int del(int value );
        static void Main(string[] args)
        {
            del d1 = method1;
             d1 += method2;
            //int z = d1(2);
            Console.WriteLine("delegate 1 called with value ={0}",d1(2));
            // Console.WriteLine("delegate 2 called",d2);
            Console.WriteLine(Domul(d1, 5));
        }
        public static int Domul(del d3, int value)//Injecting Delegates as parameter
        {
            return (d3(value));
        }
        public  static int method1(int a)
        {
            return a * a;
        }
        public static int method2(int a)
        {
            return a; ;
        }
        
    } 
   
}

using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Hello World!");
            sample sm = new sample();
            //Console.WriteLine(sm.result(10));
            //Console.WriteLine(sm.result(10, 20));
            sm.result(a);// String is pass by reference but its value is not changed
            sm.result(ref a);//
            Console.ReadLine();
        }
    }
    
    class sample

        {
        public void somefunc(String a)
        {
            Console.WriteLine("Hi");
        }
        
public void result(ref int a)
            {
                Console.WriteLine(a+10);
            }
           public  void  result(int a,int b=20)//Optional default arguments
            {

            Console.WriteLine (a + b) ;
            }
        
        }
}

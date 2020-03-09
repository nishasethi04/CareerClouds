using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            sum s = new sum();
            s.a= 10;
            s.b = 20;
           var x= s.add();

            Console.WriteLine("X={0}", x);

        }
    }
    class sum
    {
        public int a, b;
        public int add ()

        {

            return a + b;
        }    
    
    //public double add()//WE cannot give same name without giving different arguments
    public double add(double a,double b)
        {
            return a + b;
        }

        //public var add (var x,var y)//We cannot use var keyword here
            public String add(String x, String y)
        {
            return (x + y);
        }
    
    
    
    }
}

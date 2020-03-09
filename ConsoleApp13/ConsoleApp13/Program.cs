using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            childclass b = new childclass();
            int x = 2;
            int y = 3;
            Console.WriteLine(b.cal(ref y,x));//Answer is 9
        baseclass c = new childclass();
            int g = 2;
            int h = 3;
            Console.WriteLine(c.cal(ref h, g));
        }
    }


    public class baseclass
    {
        public virtual int cal(ref int x,int y)
        {
            return x + y;
        }
    
    
    }
    public class childclass : baseclass
    {
        public override int cal(ref int x, int y)
        {
            return x / y;
        }

        public int cal(ref int x, double y)
        {
            return x * 3;

        }
    }
}

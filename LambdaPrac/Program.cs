using System;

namespace LambdaPrac
{
    class Program
    {
        delegate double somedelegate(double x);
        static void Main(string[] args)
        {
            somedelegate some= x => x * x;//We cannot use lambda without using delegates.
            Console.WriteLine("Value of x={0}",some(10));
            Func<int> someint = () => 20;
            Console.WriteLine("The value of someint={0}",someint()) ;
            //Action<int> someother = x =>sum(x);
            //someother(10);
            Func<int,int,int> someother = (u,v) => sum(u, v);
            Console.WriteLine("In Sum value={0}",someother(10,20));
            
            Func<int, int> somemore =
           x =>
           {
               Console.WriteLine("This is a statement lambda");
               return x * x;
           };
            int o = somemore(5);
        }
        

        public static int sum(int x,int y)
        {
            return x + y;
            

        }
    }
}

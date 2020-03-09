using System;

namespace COnstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A { a = 10 };
            final f = new final(obj);
            f.Calarea();
            B obj2 = new B { a = 20 };
            final f1 = new final(obj2);
            f1.Calarea();
                
        }
    }
     public interface IArea
    {
        public int a { get; set; }
        public void area();
    }
    public class A : IArea
    {

        public int a { get; set; }
        public void area()
        {
            Console.WriteLine("Area is {0}",a*a);
        }



    }
    public class B:IArea
    {
        public int a { get; set; }
        public void area()
        {
            Console.WriteLine("Area is {0}", a * a*a);
        }
    }

    public class final
    {
        private readonly IArea _a;
            public final(IArea x)
        {
            _a = x;

        }
        public void Calarea()
        {
            _a.area();

        }
    }
}

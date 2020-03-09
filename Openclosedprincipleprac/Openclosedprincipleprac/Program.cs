using System;

namespace Openclosedprincipleprac
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] s = new Shapes[2];
            s[0] = new rectangle() { x = 10, y = 20 };
            s[1] = new square() { x = 2 };
            Console.WriteLine("Area of object={0}", Area(s));

        }

        public static int Area(Shapes[] x)
        {
            int area = 0;
            foreach (var x in Shapes)
            {
                area = area + Shapes.area();
            }
            return area;

        }

        public abstract class Shapes
        {
            public abstract int area();


        }

        public class rectangle : Shapes
        {
           public int x { get; set; }
            public int y { get; set; }
            public override int area()
            {
                return (x * y);

            }
        }
        public class square : Shapes
        {
            public int x { get; set; }
            public override int area()
            {
                return( x * x);

            }



        }



    }
}

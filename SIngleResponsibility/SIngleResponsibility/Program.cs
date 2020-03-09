using System;

namespace SIngleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            rect r = new rect() { x = 10, y = 20 };
            Console.WriteLine("Area={0}",r.Area());
            DrawScreen.draw(r);
           
        }
    }


public interface Ishape
    {
        int x { get; set; }
        int y { get; set; }
        public int Area();

    }
    public class rect : Ishape
    {
        public int x { get; set; }
        public int y { get; set ; }

        public int Area()
        {
            return x * y;
        }
    }

    public class square : Ishape
    {
        public int x { get; set ; }
        public int y { get ; set; }

        public int Area()
        {
            return x * x;
        }
    }
    public static class DrawScreen
    {
        public static void draw(Ishape a)
                    {
            Console.WriteLine("Drawing to screenshape: Height={0} width={1}",a.x,a.y);

        }
    }
}



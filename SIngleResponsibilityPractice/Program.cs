using System;

namespace SIngleResponsibilityPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect r = new Rect { height = 10, width = 20 };
            Console.WriteLine( r.area());
            drawscreen.draw(r);
            print.printing(r);
            Square s = new Square { height = 30, width = 40 };
            Console.WriteLine(s.area());
            IShape c = new circle { radius = 20 };
            Console.WriteLine(c.area());            
        }
    }
    public interface IShape
    {
         double area();
    }

    public class Rect : IShape
    {

        public int height { get; set; }
        public int width { get; set; }
        public double area()
        {
            return width * height;
        }
    }

    public class Square : Rect
    {
        
        public new double  area()
        {
            return width *width;
        }
    }

    public class circle:IShape
    {
        public int radius { get; set; }

        public double area()
        {
            return Math.PI * radius*radius;
        }
    }

    public static class drawscreen
    {
        public static void draw(Rect h)
        {
            Console.WriteLine("Drawing to screen:height:{0} and width: {1}", h.height, h.width);

        }
    }
    public static class print
    {

        public static void printing(Rect s)
        {
            Console.WriteLine("Printing to printer Shape - Height: {0} Width: {1}", s.height, s.width);
        }

    }
}

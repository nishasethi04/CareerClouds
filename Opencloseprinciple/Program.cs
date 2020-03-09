using System;

public class Program
{
    public static void Main()
    {
        IShape[] objects = new IShape[2];
        objects[0] = new Rectangle() { Width = 2, Height = 2 };
        objects[1] = new Circle() { Radius = 3 };

        Console.WriteLine("Area of objects: {0}", Area(objects));
    }

    public static double Area(IShape[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Area();
        }
        return area;
    }

    public interface IShape
    {
        double Area();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public  double Area()
        {
            return Radius * Radius;
        }
    }
}
using System;

public class Program
{
    public static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.Width = 10;
        rect.Height = 20;

        Console.WriteLine("Rectangle Area: {0}", rect.getArea());

        Square square = new Square();
        square.Height = 10;
        square.Width = 20;

        Console.WriteLine("Square Area: {0}", square.getArea());
    }
}


public class Quadrilaterals
{
    public virtual int Height { get; set; }
    public virtual int Width { get; set; }
    public int getArea()
    {
        return Height * Width;
    }
}


public class Rectangle : Quadrilaterals
{

    public override int Width
    {
        get { return base.Width; }
        set { base.Width = value; }
    }
    public override int Height
    {
        get { return base.Height; }
        set { base.Height = value; }
    }

}

public class Square : Quadrilaterals  // In an "is a" relationship, the derived class is clearly a
                                      //kind of the base class
{
    public override int Height
    {
        get { return base.Height; }
        set { SetWidthAndHeight(value); }
    }

    public override int Width
    {
        get { return base.Width; }
        set { SetWidthAndHeight(value); }
    }

    private void SetWidthAndHeight(int value)
    {
        base.Height = value;
        base.Width = value;
    }
}

using System;

namespace StructPractice
{
    struct Program
    {
        static void Main(string[] args)
        {
       Product p = new Product();//WE can create parameterless constructor although we have defined parameteried constructor
            Product p1 = new Product();
            prog.Main();
            p._ID = 10;
            p.print();
            p1 = p;// Here the object is copied but changes made to p1 is not reflected in P
            p1.print();
            p1._ID = 5;
            p1.print();
            p.print();

            
        }
    }
   struct Product
    {
        public int _ID;
      /*  public Product()
        {
            this._ID = 10;

        }*/ 
        //Error Structs cannot contain explicit parameterless constructor

    /*        public Product() cANNOT override parameteried constructor
        {
            this._ID = 10;
        }*/
        public Product(int i)
        {
            this._ID = i;
    }
        public void print()
        {
            Console.WriteLine("ID={0}", this._ID);

        }
    }
    
}
namespace StructPractice
{
    public static class prog
    {
        public static void Main()
        {
            Product1 p = new Product1(10);//In class we cannot declare parameterless constructor if we have not declared one.We can override parameterless ctor in Classes but not in Structs
            Product1 p1 = new Product1(5);

            // p._ID = 10;
            p.Print();
            p1 = p;// Here the object is copied but changes made to p1 is not reflected in P
            p1.Print();

            //p1._ID = 5;
            p1.Print();
            p.Print();


        }
    }

    public class Product1
    {
        public int _ID;
        public Product1(int i)
        {
            this._ID = i;
        }
        public void Print()
        {
            Console.WriteLine("ID={0}", this._ID);

        }

    }

}
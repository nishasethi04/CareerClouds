using System;

namespace Structpractice
{

    public class Product
    {
       int _id;
        string _name;

        public int Id
        {
            get => this._id;
            set { this._id = Id; }

        }
       
        public string Name1 { get => _name; set => _name = value; }

       /*public Product(int ID,string name)
        {
            this._id = ID;
            this._name = name;

        }*/
        public void display()
        {
            Console.WriteLine("Value of ID={0}", _id);
            Console.WriteLine("Value of name={0}",Name1);
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product P1 = new Product();
               
            P1.display();

        }
    }
}

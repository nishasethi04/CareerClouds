/*You need to create a class named Product that 
 * represents a product. The class has a single property named Name.
 * Users of the Product class should be able to get and set the value of the Name property. 
 * However, any attempt to set the value of Name to an empty string or a null value should raise an exception. 
 * Also, users of the Product class should not be able to access any 
 * other data members of the Product class. How will you create such a class?*/

using System;

namespace SampleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            pro.Name = "John";
            Console.WriteLine("Name={0}", pro.Name);
            pro.Name = "Nisha";
            Console.WriteLine("Name={0}", pro.Name);
            Console.WriteLine("The product ID ={0}", pro.PID);
      Console.WriteLine("The product quantity ={0}", pro.Quantity);


        }
    }
    class Product
    {
        private String _Name;
        private int _PID = 100;
        private int _quantity=10;
      
        public int Quantity
        {
            get
            {
                return this._quantity;
            }


        }
        public string Name
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be null");
                }
                this._Name = value;

            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }

        }

        public int PID
        {
            get
            {
                return this._PID;

            }
        }


    }

}

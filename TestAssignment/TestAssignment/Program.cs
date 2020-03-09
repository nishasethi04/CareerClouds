using System;

namespace TestAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer node1 = new Customer("Nisha","Sethi",32);

            Customer node3 = node1.InsertNext("harsh","Preet",32);

            Customer node2 = node3.InsertPrev("Gul","Naaz",4);

            Customer node5 = node3.InsertNext("Joe","Smith",6);

            Customer node4 = node5.InsertPrev("sally","jones",4);



            node1.TraverseFront();

            node5.TraverseBack();
            Console.WriteLine("Hello World!");
        }
    }

internal class Customer
    {
        String FName;
        String LName;
        int date;
        public int CalculateAge(int x)
        {
            return x;

        }

        internal Customer Prev;
        internal Customer Next;
        public Customer()
        {
            FName = "";
            LName = "";
            date = 0;
            Next = null;
            Prev = null;

        }
        public Customer (String x,String y,int z)
        {
            FName = x;
            LName = y;
            date = z;
            Prev = null;
            Next = null;
        }
        public Customer InsertNext(String x,String y,int z)
        {
           Customer node = new Customer(x,y,z);

            if (this.Next == null)

            {
                                                             
            node.Prev = this;

                node.Next = null; // already set in constructor

                this.Next = node;

            }

            else

            {

                // Insert in the middle

                Customer temp = this.Next;

                node.Prev = this;

                node.Next = temp;

                this.Next = node;

                temp.Prev = node;

                // temp.next does not have to be changed

            }

            return node;

        }
        public Customer InsertPrev(String x,String y,int z)

        {

            Customer node = new Customer(x,y,z);

            if (this.Prev == null)

            {

                node.Prev = null; // already set on constructor

                node.Next = this;

                this.Prev = node;

            }

            else

            {



                // Insert in the middle

                Customer temp = this.Prev;

                node.Prev = temp;

                node.Next = this;

                this.Prev = node;

                temp.Next = node;

                // temp.prev does not have to be changed

            }

            return node;

        }


        public void TraverseFront()

        {

            TraverseFront(this);

        }



        public void TraverseFront(Customer node)

        {

            if (node == null)

                node = this;

            System.Console.WriteLine("\n\nTraversing in Forward Direction\n\n");

               while (node != null)

            {
                System.Console.WriteLine(node.FName);
                System.Console.WriteLine(node.LName);
                System.Console.WriteLine(node.date);


                node = node.Next;

            }

        }



        public void TraverseBack()

        {

            TraverseBack(this);

        }



        public void TraverseBack(Customer node)

        {

            if (node == null)

                node = this;

           // System.Console.WriteLine("\n\nTraversing in Backward Direction\n\n");

            while (node != null)

            {

                System.Console.WriteLine(node.FName);
                System.Console.WriteLine(node.LName);
                System.Console.WriteLine(node.date);

                node = node.Prev;

            }

        }


    }

}

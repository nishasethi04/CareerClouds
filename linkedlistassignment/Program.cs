using System;

namespace linkedlistassignment
{
    class Program
    {
        static void Main(string[] args)
        {
             Customer c1 = new Customer();
            c1.FName = "John";
            c1.LName = "Smith";
            c1.dob = new DateTime(1999,12,23);
            Console.WriteLine(c1.calculate_age());
            Customer c2 = new Customer();
            c2.FName = "Nisha";
            c2.LName = "Sethi";
            c2.dob = new DateTime(1985, 11, 04);
            Console.WriteLine(c2.calculate_age());
            Customer c3=new Customer();
            c3.FName = "Harsh";
            c3.LName = "Walia";
            c3.dob = new DateTime(1987, 07, 25);
            Console.WriteLine(c3.calculate_age());

            c1.prev = null;
            c2.prev = c1;
            c3.prev = c2;
            c1.Next = c2;
            c1.Next = c2;
            c2.Next = c3;
            c3.Next = null;
            Customer head = c1;
            Customer tail = c3;
           while(head!=null)
            {
                Console.WriteLine(head.FName);
                Console.WriteLine(head.LName);
                Console.WriteLine(head.calculate_age());
                head=head.Next;
            }
           while(tail!=null)
            {
                Console.WriteLine(tail.FName);
                Console.WriteLine(tail.LName);
                Console.WriteLine(tail.calculate_age());
                tail = tail.prev;
            }
            }


        }
    }
    class Customer
    {
        public String FName
        {
            get;set;
        }
       public String LName
        { get; set; }
        public DateTime dob
        {
            get;set;
        }

        public int calculate_age()
        {
            int age;
            age = DateTime.Now.Year - dob.Year;
            return age;

        }
        public Customer prev
        {
            get;set;
        }
        public Customer Next
        {
            get;set;
        }
        
        
        

    }


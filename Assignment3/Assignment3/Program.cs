using System;

namespace Assignment3
{
    class Customer
    {
        static void Main(string[] args)
        {
            public string FirstName { get; set; }

        String Firstname;
            String Lastname;
            DateTime dob;
            Console.WriteLine("Enter First name, Last name and Date of Birth");
            Firstname=Console.ReadLine();
            Lastname=Console.ReadLine();
            dob = Convert.ToDateTime(Console.ReadLine());
            internal Customer prev;
            internal Customer next;
        public Customer(String s,String y,DateTime z)
        {

        }

            //datetime age = Cal_Age(DateTime dob);
        }

        public static datetime Cal_Age(DateTime dateTime, DateTime dob)
        {
            return (DateTime.Now - dob);
        }
    }
}

using System;

namespace ExtensionMethodsPrac
{
    class Program
    {
        static void Main(string[] args)

        {

            int a = new int(20);
            a.ToInt

            DateTime dateTime = new DateTime(2014, 05, 12);
            Console.WriteLine(dateTime.Toformat());

            // write to console the date format using the extension method - with bool parameter
            Console.WriteLine(new DateTime(2014,09,08).Toformat(false));


            // write to console the string format using the string extension method
            string myString = "this is my string";
            Console.WriteLine(myString.Toformat());
        }

    }
    
}

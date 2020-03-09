using System;

namespace ChainingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chaining Methods Practice");
            string a = "Nisha";
            Console.WriteLine(a.Pluralize().Capital());
        }
    }

    public static class Plural
    {
        public static string Pluralize(this string mystring)
        {
            return mystring += 's';
        }
    }

    public static class Capitalize
        {

        public static string Capital(this string newstring)
    {
            string mystring;
            mystring = newstring.ToUpper();
            return mystring;
    }
    }
}

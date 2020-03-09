using System;
using System.Linq;

namespace ConsoleApp17
{
    
        class Program
        {
            static void Main(string[] args)
            {
                string mystring = "Nisha Sethi ";
                Console.WriteLine(mystring.Stringextension());

            }
        }

        public static class StringEx
        {
            public static string Stringextension(this string mystring)
            {

                char[] a = mystring.ToArray();
                Array.Reverse(a);
               String z=a.ToString();
            return z;
            }

        }




}

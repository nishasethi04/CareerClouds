﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "Nisha Sethi ";
            Console.WriteLine(mystring.StringExtension());
                
        }
    }
    public static class MyReverse
    {
        public static String StringExtension(this string mystring)
        {


            
            char[] a = mystring.ToCharArray();
            Array.Reverse(a);
            return new string(a);


        }
    }
}

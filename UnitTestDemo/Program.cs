using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
             
            
            
        }
    }

   

    public class sum
    {
        public int x { get; set; }
        public int y { get; set; }

        public void add()
        {
            Console.WriteLine("Enter a and b value");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            
            if (x == y)
            {

               
                Console.WriteLine("Division is =", x/y);
            }
            else if(x>y)
            {
                Console.WriteLine("Addition is",x/y);

            }
            else
                Console.WriteLine("Y is greater than x");
        }



    }
}

using System;

namespace FinalQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult []a=new Adult[2];
            a[0] = new Adult() { FName="Joe" ,LName="Smith"};
            a[1] = new child() { FName = "Sally", LName = "John" };

            foreach(var item in a)
            {
                Console.WriteLine($"{item.FName} {item.LName}");
                
            }


            
        }
        public class Adult

        {
            public String FName

            {
                get;
                set;
            }
            public String LName
            {
                get;set;
            }

        }
        public class child:Adult
        {
           
        }
   
    
    
    }

}

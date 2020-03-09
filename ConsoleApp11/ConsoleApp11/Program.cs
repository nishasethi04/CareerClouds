using System;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main()
        {
            // the class assigned to the variable captain is Anonymous 
            var captain = new { FirstName = "James", MiddleName = "T", LastName = "Kirk" };
            var cap = new { FName = "hello", Nname = "Hi" };

            // display the anonymous type -- notice that even though the type is anonymous VisualStudio still knows that it has 
            //    the FirstName and LastName fields 
            Console.WriteLine("{0} {1}", captain.FirstName,captain.LastName);
            Console.WriteLine("{0} {1}", cap.FName, cap.Nname);

        }
    }
    public partial class employee
    {
        public int ID;
    }
    public void Displya()
    {
        ;
    }
}

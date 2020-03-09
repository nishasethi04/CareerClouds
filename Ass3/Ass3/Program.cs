using System;

namespace Ass3
{
    public static class Calculate
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime dateOfBirth;
            Console.Write("Enter DOB");
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
        }
       public static  int GetAge(this DateTime dateOfBirth)
        {
            //var today = DateTime.Today;

            //var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            //var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            //return (a - b);
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (dateOfBirth.DayOfYear > DateTime.Now.DayOfYear)
                age--;

            return age;
        }


    }


}

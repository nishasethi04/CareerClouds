using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person();
            person.ID1 = 101;
            person.Name = "John";
            Console.WriteLine("ID={0} and Name={1}", person.ID1, person.Name);
            Student stu = new Student();
            stu.Rno = 201;
            stu.Name = "Harry";
            stu.weight = 13.45;
            stu.Height = 98.9;

            Console.WriteLine("Roll No={0} and Name={1}", stu.Rno, stu.Name);

            Employee emp = new Employee();
            emp.EID1 = 103;
            emp.Name = "Employee";
            Console.WriteLine("EMployee ID ={0} and Name={1}", emp.EID1, emp.Name);
        }
    }

    class Person
    {
        private String _Name;
        private int _ID;


        public int ID1 { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
    }

    public interface forperson
    {


        double Height { get; set; }
        double weight { get; set; }
        void printweight();
        {
        } 

        class Student : Person, forperson
        {
            private int _rno;
            public double Height { get; set; }
            public double weight { get; set; }
            public int Rno { get => _rno; set => _rno = value; }
         void printweight()


            {
                Console.WriteLine("Hi In Student Class");
       }
        }
        class Employee : Student
        {
            public int EID1 { get; set; }
        }
    }

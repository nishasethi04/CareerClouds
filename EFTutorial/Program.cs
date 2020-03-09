using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace EFTutorial
{
    
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    Name = "Bill"
                };
                

                context.students.Add(std);
                context.SaveChanges();

                var s1 = new Student()
                {
                    Name = "John"
                };
                context.students.Add(s1);
                context.SaveChanges();

            }    }
    }
        public class SchoolContext : DbContext
        {
            public DbSet<Student> students { get; set; }
            public DbSet<Course> Courses { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-242JGDJ\HUMBERBRIDGING;Database=SchoolDatabase;Trusted_Connection=True;");

            }
        }

        public class Student
    {[Key]
        public int SID { get; set; }
        public String Name { get; set; }
    }
    public class Course
    {
        [Key]
        public int CID { get; set; }
        public string CourseName { get; set; }
    }

}

using System;

namespace SchoolDb
{
    class Program
    {
        public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"DESKTOP-242JGDJ\HUMBERBRIDGING;");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }


}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace STudentTeacherEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentContext context = new StudentContext();
            context.Database.EnsureCreated();
        }
    }
    public class StudentContext : DbContext
    {
    
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-242JGDJ\HUMBERBRIDGING;Initial Catalog=SchoolDb;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.SID, sc.CID });
            modelBuilder.Entity<StudentCourse>
                (entity =>
                {
                    entity.HasOne(sc => sc.student)
                    .WithMany(s => s.studentCourses)
                    .HasForeignKey(sc => sc.SID);
                });

            modelBuilder.Entity<StudentCourse>
                (entity =>
                { 
                entity.HasOne(sc => sc.course)
                .WithMany(s => s.studentcourses)
                .HasForeignKey(sc => sc.CID);

            });
            modelBuilder.Entity<Student>
                (entity =>
                {
                    entity.HasOne(e => e.teacher)
                    .WithMany(p => p.students)
                    .HasForeignKey(e => e.TID);



                });
            modelBuilder.Entity<Grades>
                (entity =>

                {
                    entity.HasOne(e => e.Student)
                    .WithMany(p => p.grades)
                    .HasForeignKey(e => e.SID);


                }

                );

            modelBuilder.Entity<Course>
                (
               entity =>
               {
                   entity.HasOne(e => e.teacher)
                      .WithMany(p => p.courses)
                      
                      .HasForeignKey(e => e.TID);
                   
               }

                );
            modelBuilder.Entity<Grades>
                (
               entity =>
               {
                   entity.HasOne(e => e.course)
                   .WithOne(p => p.grade)
                   .HasForeignKey<Course>(p => p.CID);
                      
               }

                );

          }


    }


    public class Student
    {
        [Key]
        public int SID { get; set; }
        public int TID { get; set; }
        String SName { get; set; }
      //  public ICollection<Course> Courses { get; set; }
        public Teacher teacher { get; set; }
        public ICollection<Grades> grades { get; set; }
        public ICollection<StudentCourse> studentCourses { get; set; }


    }
    public class Teacher
    {
        [Key]
        public int TID { get; set; }
        String TName { get; set; }
        public ICollection<Course> courses { get; set; }
        public ICollection<Student> students { get; set; }

    }

    public class Course
    {
        [Key]
        public int CID { get; set; }
  //      public int GID { get; set; }
        public int TID { get; set; }
       
        String Name { get; set; }
        public Teacher teacher { get; set; }
       // public ICollection<Student> Students { get; set; }
        public Grades grade { get; set; }
        public ICollection<StudentCourse> studentcourses { get; set; }

    }
    public class Grades
    {
        [Key]
        public int GID { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
       public int SID { get; set; }
        public int CID { get; set; }
        public Course course { get; set; }
        public Student Student{ get; set; }
       // public Grades grade { get; set; }
    }

    public class StudentCourse
    {
        public int SID { get; set; }
            public Student student { get; set; }
        public int CID { get; set; }
        public Course course { get; set; }

    }
}

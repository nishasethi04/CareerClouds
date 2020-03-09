using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext context = new SchoolContext();
            context.Database.EnsureCreated();
        }
    }


    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=CSHARPHUMBER\HUMBERBRIDGING;Initial Catalog=SCHOOL_DB;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void 
            OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SubjectStudents>(entity =>
            {
                entity.HasKey(k => 
                new { k.StudentId, k.SubjectId });

                entity.HasOne(d => d.Subjects)
                .WithMany(e => e.SubjectStudents)
                .HasForeignKey(f => f.SubjectId);

                entity.HasOne(d => d.Students)
                .WithMany(e => e.SubjectStudents)
                .HasForeignKey(f => f.StudentId);
            });



            base.OnModelCreating(modelBuilder);
        }
    }




    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public ICollection<SubjectStudents> SubjectStudents { get; set; }
    }

    //public class Mark
    //{
    //}

    public class SubjectStudents
    {
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public Student Students { get; set;}
        public Subject Subjects { get; set; }

    }


    public class Subject
    {
        [Key]
        public Guid MumboJumbo { get; set; }
        public string Name { get; set; }
        public int Term { get; set; }
        public int Hours { get; set; }
        public ICollection<SubjectStudents> SubjectStudents { get; set; }

    }
}

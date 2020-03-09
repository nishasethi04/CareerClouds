using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class EFCore: DbContext
    {

        public DbSet<Book> books { get; set; }
        public DbSet<User> user { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-242JGDJ\\HUMBERBRIDGING;Initial Catalog=BookIssue;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>
                (entity =>
                {
                    entity.HasOne(e => e.user)
                    .WithMany(p => p.books);


                }
                );
           
                
        }

    }
}

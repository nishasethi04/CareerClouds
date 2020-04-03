using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Bookstorecontext: DbContext
    {
        //public Bookstorecontext():base("Connectonstring")
        //{

        //}
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=JOB_PORTAL_DB;Integrated Security=True");
        }

        public DbSet<Users> users { get; set; }
        public DbSet<Book> books { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazerPagesDemo.Model;

namespace RazerPagesDemo.Data
{
    public class RazerPagesDemoContext : DbContext
    {
        public RazerPagesDemoContext (DbContextOptions<RazerPagesDemoContext> options)
            : base(options)
        {
        }

        public DbSet<RazerPagesDemo.Model.Member> Member { get; set; }
    }
}

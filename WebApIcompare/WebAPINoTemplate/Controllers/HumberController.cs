using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPINoTemplate.Controllers
{
    public class HumberController : ApiController
    {
    }
    public class OrderContext:DbContext
    {
        DbSet<ProductPoco> Products { get; set; }
        DbSet<OrderPoco> Order { get; set; }
        public OrderContext(string connectionstring):base(connectionstring)
        {
            Database.

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
             
            
            
            base.OnModelCreating(modelBuilder);
        }


    }

    [Table("Products")]
    public class ProductPoco
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }


    [Table("Orders")]
    public class OrderPoco
    {
        public Guid ID { get; set; }
        public int OrderNo { get; set; }

public DateTime OrderDate { get; set; }
        public virtual ICollection<ProductPoco> Products { get; set; }
    }


}

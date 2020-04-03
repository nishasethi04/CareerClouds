using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Book
    {public int BookID { get; set; }
        public string Name{get;set;}
 public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }

        public ICollection<Users> users { get; set; }

    }
}

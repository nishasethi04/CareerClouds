using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
   public DateTime DateofBirth { get; set; }

        public Book book { get; set; }
    }
}

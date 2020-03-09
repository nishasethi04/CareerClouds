using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POCO
{
    public class Book
    {
        [Key]
        public Guid BookID { get; set; }
        
        public String BName{get;set;}
        public string ISBN { get; set; }
        public DateTime Published_date { get; set; }
        public virtual User user { get; set; }
        
                          
    }

    public class User
    {
        [Key]
        public Guid UID { get; set; }
        public string name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public virtual ICollection<Book> books { get; set; }
    }
}

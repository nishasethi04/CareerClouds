using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryManagement.Pocos
{
    [Table("Users")]
    public class UsersPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [Column("User_Name")]
        public string UserName { get; set; }

        [Column("Date_of_Birth")]
        public DateTime DOB { get; set; }      
        
        public virtual ICollection<BookPoco> Books { get; set; }
    }
}

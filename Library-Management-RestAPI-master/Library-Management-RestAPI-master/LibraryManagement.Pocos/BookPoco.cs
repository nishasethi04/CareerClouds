using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryManagement.Pocos
{
    [Table("Book")]
    public class BookPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Column("Book_Name")]
        public string BookName { get; set; }

        public int ISBN { get; set; }

        [Column("Published_Date")]
        public DateTime PublishedDate { get; set; }

        [ForeignKey("User_ID")]
        public virtual UsersPoco User { get; set; }
    }
}

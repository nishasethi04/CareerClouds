using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RazerPagesDemo.Model
{
    public class Member
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public decimal amount { get; set; }
    }
}

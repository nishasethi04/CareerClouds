using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChooseTheMood.Models
{
    public class Book  //POCO This has only state as properties
    {
        public int ID { get; set; }
        public String Name { get; set; }
       

    }
    //This will be open up in /book/random so we have to create a controller called ookcontroller 
   // with method random


}
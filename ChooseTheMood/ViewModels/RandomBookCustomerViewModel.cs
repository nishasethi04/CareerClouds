using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChooseTheMood.Models;

namespace ChooseTheMood.ViewModels
{
    public class RandomBookCustomerViewModel
    {
        public Book book { get; set; }
        public List<Customers> customers { get; set; }

    }
}
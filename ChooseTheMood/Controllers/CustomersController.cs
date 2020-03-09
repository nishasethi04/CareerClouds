using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChooseTheMood.Models;

namespace ChooseTheMood.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        var customer = new List<Customers>
            {
               new Customers{ Name = "John" },
            new Customers { Name = "Sally" }

             };

        public ActionResult Index()
        {
            return View();
        }
    }
}
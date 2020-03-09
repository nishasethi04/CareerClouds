using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChooseTheMood.Models;
using System.Collections.Generic;
using ChooseTheMood.ViewModels;

namespace ChooseTheMood.Controllers
{
    public class BookController : Controller
    {
        // GET: /Book/random
        public ActionResult Random()
        {
            var b1 = new Book() { Name = "War and Peace" };
            
            var ran = new RandomBookCustomerViewModel
            {
                book = b1,
                
            };

            return View(b1);
            //return Content("Hello WOrld!!");
            //return HttpNotFound();
            // return new EmptyResult();
            //return RedirectToAction("Contact", "Home",new { page = 1, sortby = "name" });
        }
        public ActionResult Index(int? pageIndex,string sortby)

        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if(String.IsNullOrWhiteSpace(sortby))
            {
                sortby = "Name";
            }
            return Content(String.Format("Page Index={0} and SortBy={1}", pageIndex, sortby));
        }
    
        [Route("book/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
    public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);
        }
    
    }
}
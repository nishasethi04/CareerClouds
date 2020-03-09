using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleCode.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public string Action1()
        {
            return "String returned from Action1";
        }
        public ActionResult Action2()
        {
            ViewBag.Title = " Title for Action2";
            ViewBag.Message=" Message is passed from Action2";
            return View();
        }

        public ActionResult Action4()
        {
            ViewBag.Message("Not preffered a[pproach");
            return View();

        }
    }
}
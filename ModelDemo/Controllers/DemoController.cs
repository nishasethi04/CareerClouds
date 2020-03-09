using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public String Action1()
        {

            return "String returned from Action1";

        }
        public ActionResult ACtion2()
        {
            TempData["My data"] = "This is data in ACtion 2";
            return View();
        }


       // [ActionName("Create")]
        [Route("Demo/Create")]
        public ActionResult Action3()
        {
            
            ViewBag.Title = " This tiltle Action3 from ViewBag";
            ViewBag.Message = "Hello this is content of ViewBag fom Action3";
            ViewBag.Date = DateTime.Now;
            ViewData["Message"] = "Today is great day";
           
            if (TempData["My data"]!=null)
            {
                var data = TempData["My data "] as String;
            }
            return View();
        }


        public ActionResult Action4()
        {
            ViewBag.Message = "View is constructing its own Model and its nt the preffered approach";
            return View();

        }

        public ActionResult Action5()
        {
            ViewBag.Message = "View is retrieving data from Model";
            Member m = new Member() { Fname = "Nisha", LName = "Sethi", MemberID = 101 };
            //Sport s = new Sport() { SportID = 201 };
            return View(m);
            //return View(s);
        }

        public ActionResult Action7()
        {
            List<Member> memberlist = new List<Member>();
            ViewBag.Message="This is from ACtion 7 using COllection";
            Member m1 = new Member();
            m1.LName = "Sethi";
            m1.Fname = "Nisha";
            m1.MemberID = 101;
            memberlist.Add(m1);


            Member m2 = new Member() 
            { MemberID = 102, Fname = "Harsh", LName= "Walia" };
            memberlist.Add(m2);
            memberlist.Add(new Member() { MemberID = 103, Fname = "Gulnaaz", LName = "Kaur" });

            return View(memberlist);
        
        
        }
        public ActionResult Action8()
        {
            ViewBag.Message = "This is Action 8 and contain View Model";
            EndOfTheDayReportVM eodvm = new EndOfTheDayReportVM();
            Member m = new Member() 
            {
                MemberID = 101, Fname = "Nisha", LName = "Sethi" };
            eodvm.memofday = m;


            eodvm.mostplayed.Add(new GameClub() { GameID = 101, GameTitle = "Mario", price = 200 });
            eodvm.mostplayed.Add(new GameClub() { GameID = 102, GameTitle = "COntra", price = 300 });
            eodvm.mostplayed.Add(new GameClub() { GameID = 103, GameTitle = "TeenPatti", price = 400 });

            return View(eodvm);


        }
    }
}
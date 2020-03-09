using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DALGame;
using System.Net;

namespace MVCUIGameClubUI.Controllers
{
    public class GamesController : Controller
    {
        // GET: 

        private NET036DemoDBEntities db = new NET036DemoDBEntities();
        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }


        public ActionResult Details(int? id)
        {

            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Game g = db.Games.Find(id);
            if (g == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            return View(g);

        }

        public ActionResult Create()
        {
            return View();

        }
        
        [HttpPost]
  public ActionResult Create([Bind(Include="GameTitle,Price")] Game  g)
        {

            if (ModelState.IsValid)
            {
                db.Games.Add(g);
                db.SaveChanges();


                return RedirectToAction("Index");

            }
            else
            {
                return View(g);
            }

        }
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Game g = db.Games.Find(id);

            if (g == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            }
            else
                return View(g);

        }
        [HttpPost]
        public ActionResult Edit([Bind(Include ="Id,GameTitle,Price")]Game g)
        {

            if (ModelState.IsValid)
            {
                db.Entry(g).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            else
                return View(g);
        }



    }
}
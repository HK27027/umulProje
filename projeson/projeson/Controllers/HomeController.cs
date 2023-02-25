using projeson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeson.Controllers
{
    public class HomeController : Controller
    {
        tasımaEntities3 db = new tasımaEntities3();
        tasımatablosu t = new tasımatablosu();
        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Index(tasımatablosu t)
        {
           
            db.tasımatablosu.Add(t);
            db.SaveChanges();
            return View();
        }


        public ActionResult About()
        {
          

            var tasıma = db.tasımatablosu.ToList();
            return View(tasıma);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult sil(int id)
        {
            var ts = db.tasımatablosu.Find(id);
            db.tasımatablosu.Remove(ts);
            db.SaveChanges();
            return RedirectToAction("About");
        }
    }
}
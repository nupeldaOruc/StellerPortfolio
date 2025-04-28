using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Steller.Models;

namespace Steller.Controllers { 

    public class AboutController : Controller
{ 
         StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();
  
   
        public ActionResult Index()
        {
            var aboutList = db.TblAbout.ToList();

            return View(aboutList);
        }
        public ActionResult DeleteAbout(int id)
        {
            var about = db.TblAbout.Find(id);
            db.TblAbout.Remove(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(TblAbout about) { 

            db.TblAbout.Add(about);

        //    var about = db.TblAbout.Find( AboutId);
          // db.TblAbout.Remove(about);
           db.SaveChanges();
            return RedirectToAction("ındex");
        }
    }
    }      


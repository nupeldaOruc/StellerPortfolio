using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Steller.Models;



namespace Steller.Controllers
{
    public class FeatureController : Controller
    {
        StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();

        public ActionResult Index()
        {
            var values = db.tblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFeature(tblFeature feature)
        {
            db.tblFeature.Add(feature);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteFeature(int id)
        {
            var value = db.tblFeature.Find(id);
            db.tblFeature.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.tblFeature.Find(id);
          
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(tblFeature feature)
        {
        var value = db.tblFeature.Find(feature.featuredID);
            value.NameSurname = feature.NameSurname;
            value.Title = feature.Title;
            value.job = feature.job;
            value.image = feature.image;
            value.CVdowlondurl = feature.CVdowlondurl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
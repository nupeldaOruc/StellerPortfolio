using Steller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller.Controllers
{
    public class ContatController : Controller
    {
        StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();
        public ActionResult Index()
        {
            var values = db.TblContat.ToList();
            return View(values);
        }
        public ActionResult DeleteContat(int id)
        {
            var value = db.TblContat.Find(id);
            db.TblContat.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddContat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContat(TblContat contat)
        {
            db.TblContat.Add(contat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContat(int id)
        {
            var value = db.TblContat.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContat(TblContat contat)
        {
            var value = db.TblContat.Find(contat.ContacId);
            value.Phone= contat.Phone;
            value.Adress= contat.Adress;
            value.Email=contat.Email;
            value.MapUrl = contat.MapUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}


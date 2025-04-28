using Steller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller.Controllers
{
    public class SocialMedyaController : Controller
    {
        StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();
        public ActionResult Index()
        {
            var values = db.TblSocial.ToList();
            return View(values);
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var values = db.TblSocial.Find(id);
            db.TblSocial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddSocialMedya()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedya(TblSocial social)
        {
            db.TblSocial.Add(social);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSocialMedya(int id)
        {
            var values = db.TblSocial.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedya(TblSocial social)
        {
            var value = db.TblSocial.Find(social.SocialMedyaID);
            value.SocialMedyaAD = social.SocialMedyaAD;
            value.Icon = social.Icon;
            value.Url = social.Url;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
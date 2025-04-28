using Steller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();
         
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DefaultFeaturePartial()
        {
            ViewBag.project = db.TblProject.Count();
            ViewBag.testimonial = db.Testimonial.Count();
            ViewBag.skill = db.TblSkiil.Count();
            var values = db.tblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultAboutPartial()
        {
            var value = db.TblAbout.ToList();
            return PartialView(value);
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            var values = db.TblMsj.ToList();
            return PartialView(values);
        }
        [HttpPost]
        public ActionResult SendMessage(TblMsj msj)
        {
            db.TblMsj.Add(msj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult DefaultServicePartial()
        {
            var values = db.TblService.Where(x => x.ServicesStatus == true).ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultSkillPartial()
        {
            var values = db.TblSkiil.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultProjePartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultTestimonialPartial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultContactInfoPartial()
        {
            var values = db.TblContat.ToList();
            return PartialView(values);
        }

        public PartialViewResult UILayoutFooterPartial()
        {
            var values = db.TblSocial.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultSocialMediaPartial()
        {
            var values = db.TblSocial.ToList();
            return PartialView(values);
        }
    }
}
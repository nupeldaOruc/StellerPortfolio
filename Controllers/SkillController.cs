using Steller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller.Controllers
{
    public class SkillController : Controller
    {
        StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();
        public ActionResult Index()
        {
            var values = db.TblSkiil.ToList();
            return View(values);
        }
        public ActionResult DeleteSkill(int id)
        {
            var values = db.TblSkiil.Find(id);
            db.TblSkiil.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkiil skill)
        {
            var values = db.TblSkiil.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult  UpdateSkill(int id)
        {
            var values = db.TblSkiil.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkiil skill)
        {
            var values = db.TblSkiil.Find(skill.SKILLID);
            values.SkillName = skill.SkillName;
            values.Title = skill.Title;
            values.Value = skill.Value; 
            values.Description = skill.Description;
            db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
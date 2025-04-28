using Steller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller.Controllers
{
    public class MessageController : Controller
    {
        StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();

        public ActionResult Index()
        {
            var valuees = db.TblMsj.Where(x=> x.IsRead==false).ToList();
            return View();
        }
        public ActionResult MessageDetail(int id)
        {
            var message = db.TblMsj.Find(id);
            db.SaveChanges();
            return View (message);
        }
        public ActionResult ReadMessages()
        {
            var values = db.TblMsj.Where(x => x.IsRead == true).ToList();
            return View(values);
        }
    }
}
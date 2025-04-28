using Steller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller.Controllers
{
    public class ServiseController : Controller
    {
        StellerAcunMedyaDbEntities1 db = new StellerAcunMedyaDbEntities1();
        // GET: Servise
        public ActionResult Index()
        {
            var values = db.TblService.ToList();
            return View();
        }
        public ActionResult DeleteService(int id)
        {
            var values = db.TblService.Find(id);
            db.TblService.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(TblService service)
        {
            service.ServicesStatus = false;
            db.TblService.Add(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateService(int id)
        {
            var value = db.TblService.Find(id);
            return View(value);
        }
            [HttpPost]
        public ActionResult UpdateService(TblService service)
        {
            var value = db.TblService.Find(service.servicID);
            value.servicedName = service.servicedName;
            value.ServicesStatus = service.ServicesStatus;
            value.serviceliconUrl = service.serviceliconUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MakeActive(int id)
        {
            var value = db.TblService.Find(id);
            value.ServicesStatus = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MakePassive(int id)
        {
            var value = db.TblService.Find(id);
            value.ServicesStatus = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
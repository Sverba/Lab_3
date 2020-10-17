using DTPReg.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTPReg.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DTPContext db = new DTPContext();
        public ActionResult Index()
        {
            return View(db.Registrations);
        }
        public ActionResult RegView(int id)
        {
            var reg = db.Registrations.Find(id);
            if (reg != null)
            {
                return View(reg);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditReg(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Registration reg = db.Registrations.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }
        [HttpPost]
        public ActionResult EditReg(Registration reg)
        {
            db.Entry(reg).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Registration reg)
        {
            db.Registrations.Add(reg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Registration reg = db.Registrations.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Registration reg = db.Registrations.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            db.Registrations.Remove(reg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
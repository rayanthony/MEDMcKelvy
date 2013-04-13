using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MEDMcKelvy.Models;

namespace MEDMcKelvy.Controllers
{
    public class TechnologyController : Controller
    {
        private MEDMcKelvyDBContext db = new MEDMcKelvyDBContext();

        //
        // GET: /Technology/

        public ActionResult Index()
        {
            return View(db.Technology.ToList());
        }

        //
        // GET: /Technology/Details/5

        public ActionResult Details(int id = 0)
        {
            Technology technology = db.Technology.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        //
        // GET: /Technology/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Technology/Create

        [HttpPost]
        public ActionResult Create(Technology technology)
        {
            if (ModelState.IsValid)
            {
                db.Technology.Add(technology);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(technology);
        }

        //
        // GET: /Technology/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Technology technology = db.Technology.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        //
        // POST: /Technology/Edit/5

        [HttpPost]
        public ActionResult Edit(Technology technology)
        {
            if (ModelState.IsValid)
            {
                db.Entry(technology).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(technology);
        }

        //
        // GET: /Technology/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Technology technology = db.Technology.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        //
        // POST: /Technology/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Technology technology = db.Technology.Find(id);
            db.Technology.Remove(technology);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
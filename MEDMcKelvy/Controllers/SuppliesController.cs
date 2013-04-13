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
    public class SuppliesController : Controller
    {
        private MEDMcKelvyDBContext db = new MEDMcKelvyDBContext();

        //
        // GET: /Supplies/

        public ActionResult Index()
        {
            return View(db.Supplies.ToList());
        }

        //
        // GET: /Supplies/Details/5

        public ActionResult Details(int id = 0)
        {
            Supplies supplies = db.Supplies.Find(id);
            if (supplies == null)
            {
                return HttpNotFound();
            }
            return View(supplies);
        }

        //
        // GET: /Supplies/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Supplies/Create

        [HttpPost]
        public ActionResult Create(Supplies supplies)
        {
            if (ModelState.IsValid)
            {
                db.Supplies.Add(supplies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(supplies);
        }

        //
        // GET: /Supplies/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Supplies supplies = db.Supplies.Find(id);
            if (supplies == null)
            {
                return HttpNotFound();
            }
            return View(supplies);
        }

        //
        // POST: /Supplies/Edit/5

        [HttpPost]
        public ActionResult Edit(Supplies supplies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supplies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supplies);
        }

        //
        // GET: /Supplies/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Supplies supplies = db.Supplies.Find(id);
            if (supplies == null)
            {
                return HttpNotFound();
            }
            return View(supplies);
        }

        //
        // POST: /Supplies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Supplies supplies = db.Supplies.Find(id);
            db.Supplies.Remove(supplies);
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
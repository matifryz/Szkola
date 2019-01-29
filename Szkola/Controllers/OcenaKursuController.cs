using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Szkola.DBAcess;
using Szkola.Models;

namespace Szkola.Controllers
{
    public class OcenaKursuController : Controller
    {
        private SzkolaContext db = new SzkolaContext();

        // GET: OcenaKursu
        public ActionResult Index()
        {
            var ocenaKursu = db.OcenaKursu.Include(o => o.Student);
            return View(ocenaKursu.ToList());
        }

        // GET: OcenaKursu/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OcenaKursu ocenaKursu = db.OcenaKursu.Find(id);
            if (ocenaKursu == null)
            {
                return HttpNotFound();
            }
            return View(ocenaKursu);
        }

        // GET: OcenaKursu/Create
        public ActionResult Create()
        {
            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent");
            return View();
        }

        // POST: OcenaKursu/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdOcena,IdKurs,IdStudent,Ocena")] OcenaKursu ocenaKursu)
        {
            if (ModelState.IsValid)
            {
                db.OcenaKursu.Add(ocenaKursu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent", ocenaKursu.IdStudent);
            return View(ocenaKursu);
        }

        // GET: OcenaKursu/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OcenaKursu ocenaKursu = db.OcenaKursu.Find(id);
            if (ocenaKursu == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent", ocenaKursu.IdStudent);
            return View(ocenaKursu);
        }

        // POST: OcenaKursu/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOcena,IdKurs,IdStudent,Ocena")] OcenaKursu ocenaKursu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ocenaKursu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent", ocenaKursu.IdStudent);
            return View(ocenaKursu);
        }

        // GET: OcenaKursu/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OcenaKursu ocenaKursu = db.OcenaKursu.Find(id);
            if (ocenaKursu == null)
            {
                return HttpNotFound();
            }
            return View(ocenaKursu);
        }

        // POST: OcenaKursu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            OcenaKursu ocenaKursu = db.OcenaKursu.Find(id);
            db.OcenaKursu.Remove(ocenaKursu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

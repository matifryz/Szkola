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
    public class NauczycielController : Controller
    {
        private SzkolaContext db = new SzkolaContext();

        // GET: Nauczyciel
        public ActionResult Index()
        {
            var nauczyciele = db.Nauczyciele.Include(n => n.Student);
            return View(nauczyciele.ToList());
        }

        // GET: Nauczyciel/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nauczyciel nauczyciel = db.Nauczyciele.Find(id);
            if (nauczyciel == null)
            {
                return HttpNotFound();
            }
            return View(nauczyciel);
        }

        // GET: Nauczyciel/Create
        public ActionResult Create()
        {
            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent");
            return View();
        }

        // POST: Nauczyciel/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdNauczyciel,IdKurs,IdStudent,Ocena")] Nauczyciel nauczyciel)
        {
            if (ModelState.IsValid)
            {
                db.Nauczyciele.Add(nauczyciel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent", nauczyciel.IdStudent);
            return View(nauczyciel);
        }

        // GET: Nauczyciel/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nauczyciel nauczyciel = db.Nauczyciele.Find(id);
            if (nauczyciel == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent", nauczyciel.IdStudent);
            return View(nauczyciel);
        }

        // POST: Nauczyciel/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdNauczyciel,IdKurs,IdStudent,Ocena")] Nauczyciel nauczyciel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nauczyciel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdStudent = new SelectList(db.Studenci, "IdStudent", "ImieStudent", nauczyciel.IdStudent);
            return View(nauczyciel);
        }

        // GET: Nauczyciel/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nauczyciel nauczyciel = db.Nauczyciele.Find(id);
            if (nauczyciel == null)
            {
                return HttpNotFound();
            }
            return View(nauczyciel);
        }

        // POST: Nauczyciel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Nauczyciel nauczyciel = db.Nauczyciele.Find(id);
            db.Nauczyciele.Remove(nauczyciel);
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

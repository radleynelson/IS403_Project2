using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CrapoDeeds.Models;
using Project2.DAL;

namespace Project2.Controllers
{
    public class CasesController : Controller
    {
        private DefaultConnection db = new DefaultConnection();

        // GET: Cases
        public ActionResult Index()
        {
            var cases = db.Cases.Include(c => c.Client);
            return View(cases.ToList());
        }

        // GET: Cases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cases cases = db.Cases.Find(id);
            if (cases == null)
            {
                return HttpNotFound();
            }
            return View(cases);
        }

        // GET: Cases/Create
        public ActionResult Create()
        {
            ViewBag.clientID = new SelectList(db.Clients, "clientID", "clientHQAddress");
            return View();
        }

        // POST: Cases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "caseID,caseName,clientID")] Cases cases)
        {
            if (ModelState.IsValid)
            {
                db.Cases.Add(cases);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.clientID = new SelectList(db.Clients, "clientID", "clientHQAddress", cases.clientID);
            return View(cases);
        }

        // GET: Cases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cases cases = db.Cases.Find(id);
            if (cases == null)
            {
                return HttpNotFound();
            }
            ViewBag.clientID = new SelectList(db.Clients, "clientID", "clientHQAddress", cases.clientID);
            return View(cases);
        }

        // POST: Cases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "caseID,caseName,clientID")] Cases cases)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cases).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.clientID = new SelectList(db.Clients, "clientID", "clientHQAddress", cases.clientID);
            return View(cases);
        }

        // GET: Cases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cases cases = db.Cases.Find(id);
            if (cases == null)
            {
                return HttpNotFound();
            }
            return View(cases);
        }

        // POST: Cases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cases cases = db.Cases.Find(id);
            db.Cases.Remove(cases);
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

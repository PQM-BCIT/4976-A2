using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;
using GoodSamaritan.Models.ClientEntity;

namespace GoodSamaritan.Controllers.Client
{
    public class CrisisController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Crisis
        public ActionResult Index()
        {
            return View(db.CrisisModel.ToList());
        }

        // GET: Crisis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrisisModel crisisModel = db.CrisisModel.Find(id);
            if (crisisModel == null)
            {
                return HttpNotFound();
            }
            return View(crisisModel);
        }

        // GET: Crisis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crisis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CrisisId,Crisis")] CrisisModel crisisModel)
        {
            if (ModelState.IsValid)
            {
                db.CrisisModel.Add(crisisModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(crisisModel);
        }

        // GET: Crisis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrisisModel crisisModel = db.CrisisModel.Find(id);
            if (crisisModel == null)
            {
                return HttpNotFound();
            }
            return View(crisisModel);
        }

        // POST: Crisis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CrisisId,Crisis")] CrisisModel crisisModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crisisModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(crisisModel);
        }

        // GET: Crisis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrisisModel crisisModel = db.CrisisModel.Find(id);
            if (crisisModel == null)
            {
                return HttpNotFound();
            }
            return View(crisisModel);
        }

        // POST: Crisis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CrisisModel crisisModel = db.CrisisModel.Find(id);
            db.CrisisModel.Remove(crisisModel);
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

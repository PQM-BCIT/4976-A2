using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;
using GoodSamaritan.Models.SmartEntity;

namespace GoodSamaritan.Controllers.Smart
{
    public class ReferredToCBVSController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferredToCBVS
        public ActionResult Index()
        {
            return View(db.ReferredToCBVSModel.ToList());
        }

        // GET: ReferredToCBVS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVSModel referredToCBVSModel = db.ReferredToCBVSModel.Find(id);
            if (referredToCBVSModel == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVSModel);
        }

        // GET: ReferredToCBVS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferredToCBVS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferredToCBVSId,ReferredToCBVS")] ReferredToCBVSModel referredToCBVSModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferredToCBVSModel.Add(referredToCBVSModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referredToCBVSModel);
        }

        // GET: ReferredToCBVS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVSModel referredToCBVSModel = db.ReferredToCBVSModel.Find(id);
            if (referredToCBVSModel == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVSModel);
        }

        // POST: ReferredToCBVS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferredToCBVSId,ReferredToCBVS")] ReferredToCBVSModel referredToCBVSModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referredToCBVSModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referredToCBVSModel);
        }

        // GET: ReferredToCBVS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVSModel referredToCBVSModel = db.ReferredToCBVSModel.Find(id);
            if (referredToCBVSModel == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVSModel);
        }

        // POST: ReferredToCBVS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferredToCBVSModel referredToCBVSModel = db.ReferredToCBVSModel.Find(id);
            db.ReferredToCBVSModel.Remove(referredToCBVSModel);
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

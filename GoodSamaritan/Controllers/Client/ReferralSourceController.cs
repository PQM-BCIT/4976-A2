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
    public class ReferralSourceController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferralSource
        public ActionResult Index()
        {
            return View(db.ReferralSourceMode.ToList());
        }

        // GET: ReferralSource/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSourceModel referralSourceModel = db.ReferralSourceMode.Find(id);
            if (referralSourceModel == null)
            {
                return HttpNotFound();
            }
            return View(referralSourceModel);
        }

        // GET: ReferralSource/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralSource/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferralSourceId,ReferralSource")] ReferralSourceModel referralSourceModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferralSourceMode.Add(referralSourceModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referralSourceModel);
        }

        // GET: ReferralSource/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSourceModel referralSourceModel = db.ReferralSourceMode.Find(id);
            if (referralSourceModel == null)
            {
                return HttpNotFound();
            }
            return View(referralSourceModel);
        }

        // POST: ReferralSource/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferralSourceId,ReferralSource")] ReferralSourceModel referralSourceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralSourceModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referralSourceModel);
        }

        // GET: ReferralSource/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSourceModel referralSourceModel = db.ReferralSourceMode.Find(id);
            if (referralSourceModel == null)
            {
                return HttpNotFound();
            }
            return View(referralSourceModel);
        }

        // POST: ReferralSource/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferralSourceModel referralSourceModel = db.ReferralSourceMode.Find(id);
            db.ReferralSourceMode.Remove(referralSourceModel);
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

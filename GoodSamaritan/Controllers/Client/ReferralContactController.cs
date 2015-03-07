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
    public class ReferralContactController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferralContact
        public ActionResult Index()
        {
            return View(db.ReferralContactModel.ToList());
        }

        // GET: ReferralContact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContactModel referralContactModel = db.ReferralContactModel.Find(id);
            if (referralContactModel == null)
            {
                return HttpNotFound();
            }
            return View(referralContactModel);
        }

        // GET: ReferralContact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralContact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferralContactId,ReferralContact")] ReferralContactModel referralContactModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferralContactModel.Add(referralContactModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referralContactModel);
        }

        // GET: ReferralContact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContactModel referralContactModel = db.ReferralContactModel.Find(id);
            if (referralContactModel == null)
            {
                return HttpNotFound();
            }
            return View(referralContactModel);
        }

        // POST: ReferralContact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferralContactId,ReferralContact")] ReferralContactModel referralContactModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralContactModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referralContactModel);
        }

        // GET: ReferralContact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContactModel referralContactModel = db.ReferralContactModel.Find(id);
            if (referralContactModel == null)
            {
                return HttpNotFound();
            }
            return View(referralContactModel);
        }

        // POST: ReferralContact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferralContactModel referralContactModel = db.ReferralContactModel.Find(id);
            db.ReferralContactModel.Remove(referralContactModel);
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

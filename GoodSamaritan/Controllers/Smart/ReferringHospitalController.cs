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
    public class ReferringHospitalController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferringHospital
        public ActionResult Index()
        {
            return View(db.ReferringHospitalModel.ToList());
        }

        // GET: ReferringHospital/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospitalModel referringHospitalModel = db.ReferringHospitalModel.Find(id);
            if (referringHospitalModel == null)
            {
                return HttpNotFound();
            }
            return View(referringHospitalModel);
        }

        // GET: ReferringHospital/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferringHospital/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferringHospitalId,ReferringHospital")] ReferringHospitalModel referringHospitalModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferringHospitalModel.Add(referringHospitalModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referringHospitalModel);
        }

        // GET: ReferringHospital/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospitalModel referringHospitalModel = db.ReferringHospitalModel.Find(id);
            if (referringHospitalModel == null)
            {
                return HttpNotFound();
            }
            return View(referringHospitalModel);
        }

        // POST: ReferringHospital/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferringHospitalId,ReferringHospital")] ReferringHospitalModel referringHospitalModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referringHospitalModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referringHospitalModel);
        }

        // GET: ReferringHospital/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospitalModel referringHospitalModel = db.ReferringHospitalModel.Find(id);
            if (referringHospitalModel == null)
            {
                return HttpNotFound();
            }
            return View(referringHospitalModel);
        }

        // POST: ReferringHospital/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferringHospitalModel referringHospitalModel = db.ReferringHospitalModel.Find(id);
            db.ReferringHospitalModel.Remove(referringHospitalModel);
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

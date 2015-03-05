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
    public class MedicalOnlyController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: MedicalOnly
        public ActionResult Index()
        {
            return View(db.MedicalOnlyModel.ToList());
        }

        // GET: MedicalOnly/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnlyModel medicalOnlyModel = db.MedicalOnlyModel.Find(id);
            if (medicalOnlyModel == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnlyModel);
        }

        // GET: MedicalOnly/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalOnly/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MedicalOnlyId,MedicalOnly")] MedicalOnlyModel medicalOnlyModel)
        {
            if (ModelState.IsValid)
            {
                db.MedicalOnlyModel.Add(medicalOnlyModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicalOnlyModel);
        }

        // GET: MedicalOnly/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnlyModel medicalOnlyModel = db.MedicalOnlyModel.Find(id);
            if (medicalOnlyModel == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnlyModel);
        }

        // POST: MedicalOnly/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MedicalOnlyId,MedicalOnly")] MedicalOnlyModel medicalOnlyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalOnlyModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicalOnlyModel);
        }

        // GET: MedicalOnly/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnlyModel medicalOnlyModel = db.MedicalOnlyModel.Find(id);
            if (medicalOnlyModel == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnlyModel);
        }

        // POST: MedicalOnly/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedicalOnlyModel medicalOnlyModel = db.MedicalOnlyModel.Find(id);
            db.MedicalOnlyModel.Remove(medicalOnlyModel);
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

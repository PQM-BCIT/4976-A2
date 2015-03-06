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
    public class FamilyViolenceFileController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: FamilyViolenceFile
        public ActionResult Index()
        {
            return View(db.FamilyViolenceFileModel.ToList());
        }

        // GET: FamilyViolenceFile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFileModel familyViolenceFileModel = db.FamilyViolenceFileModel.Find(id);
            if (familyViolenceFileModel == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFileModel);
        }

        // GET: FamilyViolenceFile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilyViolenceFile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FamilyViolenceFileId,FamilyViolenceFile")] FamilyViolenceFileModel familyViolenceFileModel)
        {
            if (ModelState.IsValid)
            {
                db.FamilyViolenceFileModel.Add(familyViolenceFileModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(familyViolenceFileModel);
        }

        // GET: FamilyViolenceFile/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFileModel familyViolenceFileModel = db.FamilyViolenceFileModel.Find(id);
            if (familyViolenceFileModel == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFileModel);
        }

        // POST: FamilyViolenceFile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FamilyViolenceFileId,FamilyViolenceFile")] FamilyViolenceFileModel familyViolenceFileModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(familyViolenceFileModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(familyViolenceFileModel);
        }

        // GET: FamilyViolenceFile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFileModel familyViolenceFileModel = db.FamilyViolenceFileModel.Find(id);
            if (familyViolenceFileModel == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFileModel);
        }

        // POST: FamilyViolenceFile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FamilyViolenceFileModel familyViolenceFileModel = db.FamilyViolenceFileModel.Find(id);
            db.FamilyViolenceFileModel.Remove(familyViolenceFileModel);
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

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
    public class DuplicateFileController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: DuplicateFile
        public ActionResult Index()
        {
            return View(db.DuplicateFileModel.ToList());
        }

        // GET: DuplicateFile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFileModel duplicateFileModel = db.DuplicateFileModel.Find(id);
            if (duplicateFileModel == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFileModel);
        }

        // GET: DuplicateFile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DuplicateFile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DuplicateFileId,DuplicateFile")] DuplicateFileModel duplicateFileModel)
        {
            if (ModelState.IsValid)
            {
                db.DuplicateFileModel.Add(duplicateFileModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duplicateFileModel);
        }

        // GET: DuplicateFile/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFileModel duplicateFileModel = db.DuplicateFileModel.Find(id);
            if (duplicateFileModel == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFileModel);
        }

        // POST: DuplicateFile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DuplicateFileId,DuplicateFile")] DuplicateFileModel duplicateFileModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duplicateFileModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duplicateFileModel);
        }

        // GET: DuplicateFile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFileModel duplicateFileModel = db.DuplicateFileModel.Find(id);
            if (duplicateFileModel == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFileModel);
        }

        // POST: DuplicateFile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DuplicateFileModel duplicateFileModel = db.DuplicateFileModel.Find(id);
            db.DuplicateFileModel.Remove(duplicateFileModel);
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

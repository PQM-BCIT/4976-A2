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
    public class StatusOfFileController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: StatusOfFile
        public ActionResult Index()
        {
            return View(db.StatusOfFileModel.ToList());
        }

        // GET: StatusOfFile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFileModel statusOfFileModel = db.StatusOfFileModel.Find(id);
            if (statusOfFileModel == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFileModel);
        }

        // GET: StatusOfFile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusOfFile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StatusOfFileId,StatusOfFile")] StatusOfFileModel statusOfFileModel)
        {
            if (ModelState.IsValid)
            {
                db.StatusOfFileModel.Add(statusOfFileModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statusOfFileModel);
        }

        // GET: StatusOfFile/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFileModel statusOfFileModel = db.StatusOfFileModel.Find(id);
            if (statusOfFileModel == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFileModel);
        }

        // POST: StatusOfFile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatusOfFileId,StatusOfFile")] StatusOfFileModel statusOfFileModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusOfFileModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusOfFileModel);
        }

        // GET: StatusOfFile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFileModel statusOfFileModel = db.StatusOfFileModel.Find(id);
            if (statusOfFileModel == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFileModel);
        }

        // POST: StatusOfFile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatusOfFileModel statusOfFileModel = db.StatusOfFileModel.Find(id);
            db.StatusOfFileModel.Remove(statusOfFileModel);
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

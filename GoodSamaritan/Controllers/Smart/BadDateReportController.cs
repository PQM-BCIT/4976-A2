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
    public class BadDateReportController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: BadDateReport
        public ActionResult Index()
        {
            return View(db.BadDateReportModel.ToList());
        }

        // GET: BadDateReport/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReportModel badDateReportModel = db.BadDateReportModel.Find(id);
            if (badDateReportModel == null)
            {
                return HttpNotFound();
            }
            return View(badDateReportModel);
        }

        // GET: BadDateReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BadDateReport/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BadDateReportId,BadDateReport")] BadDateReportModel badDateReportModel)
        {
            if (ModelState.IsValid)
            {
                db.BadDateReportModel.Add(badDateReportModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(badDateReportModel);
        }

        // GET: BadDateReport/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReportModel badDateReportModel = db.BadDateReportModel.Find(id);
            if (badDateReportModel == null)
            {
                return HttpNotFound();
            }
            return View(badDateReportModel);
        }

        // POST: BadDateReport/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BadDateReportId,BadDateReport")] BadDateReportModel badDateReportModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badDateReportModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(badDateReportModel);
        }

        // GET: BadDateReport/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReportModel badDateReportModel = db.BadDateReportModel.Find(id);
            if (badDateReportModel == null)
            {
                return HttpNotFound();
            }
            return View(badDateReportModel);
        }

        // POST: BadDateReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BadDateReportModel badDateReportModel = db.BadDateReportModel.Find(id);
            db.BadDateReportModel.Remove(badDateReportModel);
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

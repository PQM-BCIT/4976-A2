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
    public class PoliceReportedController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: PoliceReported
        public ActionResult Index()
        {
            return View(db.PoliceReportedModel.ToList());
        }

        // GET: PoliceReported/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReportedModel policeReportedModel = db.PoliceReportedModel.Find(id);
            if (policeReportedModel == null)
            {
                return HttpNotFound();
            }
            return View(policeReportedModel);
        }

        // GET: PoliceReported/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceReported/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PoliceReportedId,PoliceReported")] PoliceReportedModel policeReportedModel)
        {
            if (ModelState.IsValid)
            {
                db.PoliceReportedModel.Add(policeReportedModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(policeReportedModel);
        }

        // GET: PoliceReported/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReportedModel policeReportedModel = db.PoliceReportedModel.Find(id);
            if (policeReportedModel == null)
            {
                return HttpNotFound();
            }
            return View(policeReportedModel);
        }

        // POST: PoliceReported/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PoliceReportedId,PoliceReported")] PoliceReportedModel policeReportedModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeReportedModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policeReportedModel);
        }

        // GET: PoliceReported/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReportedModel policeReportedModel = db.PoliceReportedModel.Find(id);
            if (policeReportedModel == null)
            {
                return HttpNotFound();
            }
            return View(policeReportedModel);
        }

        // POST: PoliceReported/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PoliceReportedModel policeReportedModel = db.PoliceReportedModel.Find(id);
            db.PoliceReportedModel.Remove(policeReportedModel);
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

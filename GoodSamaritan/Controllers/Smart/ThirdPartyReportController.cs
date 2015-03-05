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
    public class ThirdPartyReportController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ThirdPartyReport
        public ActionResult Index()
        {
            return View(db.ThirdPartyReportModel.ToList());
        }

        // GET: ThirdPartyReport/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReportModel thirdPartyReportModel = db.ThirdPartyReportModel.Find(id);
            if (thirdPartyReportModel == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReportModel);
        }

        // GET: ThirdPartyReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThirdPartyReport/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThirdPartyReportId,ThirdPartyReport")] ThirdPartyReportModel thirdPartyReportModel)
        {
            if (ModelState.IsValid)
            {
                db.ThirdPartyReportModel.Add(thirdPartyReportModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thirdPartyReportModel);
        }

        // GET: ThirdPartyReport/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReportModel thirdPartyReportModel = db.ThirdPartyReportModel.Find(id);
            if (thirdPartyReportModel == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReportModel);
        }

        // POST: ThirdPartyReport/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThirdPartyReportId,ThirdPartyReport")] ThirdPartyReportModel thirdPartyReportModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thirdPartyReportModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thirdPartyReportModel);
        }

        // GET: ThirdPartyReport/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReportModel thirdPartyReportModel = db.ThirdPartyReportModel.Find(id);
            if (thirdPartyReportModel == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReportModel);
        }

        // POST: ThirdPartyReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThirdPartyReportModel thirdPartyReportModel = db.ThirdPartyReportModel.Find(id);
            db.ThirdPartyReportModel.Remove(thirdPartyReportModel);
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

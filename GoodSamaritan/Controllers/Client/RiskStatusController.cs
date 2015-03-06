using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;

namespace GoodSamaritan.Controllers.Client
{
    public class RiskStatusController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: RiskStatus
        public ActionResult Index()
        {
            return View(db.RiskStatusModel.ToList());
        }

        // GET: RiskStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatusModel riskStatusModel = db.RiskStatusModel.Find(id);
            if (riskStatusModel == null)
            {
                return HttpNotFound();
            }
            return View(riskStatusModel);
        }

        // GET: RiskStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RiskStatusId,RiskStatus")] RiskStatusModel riskStatusModel)
        {
            if (ModelState.IsValid)
            {
                db.RiskStatusModel.Add(riskStatusModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(riskStatusModel);
        }

        // GET: RiskStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatusModel riskStatusModel = db.RiskStatusModel.Find(id);
            if (riskStatusModel == null)
            {
                return HttpNotFound();
            }
            return View(riskStatusModel);
        }

        // POST: RiskStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RiskStatusId,RiskStatus")] RiskStatusModel riskStatusModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskStatusModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(riskStatusModel);
        }

        // GET: RiskStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatusModel riskStatusModel = db.RiskStatusModel.Find(id);
            if (riskStatusModel == null)
            {
                return HttpNotFound();
            }
            return View(riskStatusModel);
        }

        // POST: RiskStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RiskStatusModel riskStatusModel = db.RiskStatusModel.Find(id);
            db.RiskStatusModel.Remove(riskStatusModel);
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

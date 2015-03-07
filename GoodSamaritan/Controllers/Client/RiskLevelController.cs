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
    public class RiskLevelController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: RiskLevel
        public ActionResult Index()
        {
            return View(db.RiskLevelModel.ToList());
        }

        // GET: RiskLevel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevelModel riskLevelModel = db.RiskLevelModel.Find(id);
            if (riskLevelModel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevelModel);
        }

        // GET: RiskLevel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskLevel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RiskLevelId,RiskLevel")] RiskLevelModel riskLevelModel)
        {
            if (ModelState.IsValid)
            {
                db.RiskLevelModel.Add(riskLevelModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(riskLevelModel);
        }

        // GET: RiskLevel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevelModel riskLevelModel = db.RiskLevelModel.Find(id);
            if (riskLevelModel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevelModel);
        }

        // POST: RiskLevel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RiskLevelId,RiskLevel")] RiskLevelModel riskLevelModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskLevelModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(riskLevelModel);
        }

        // GET: RiskLevel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevelModel riskLevelModel = db.RiskLevelModel.Find(id);
            if (riskLevelModel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevelModel);
        }

        // POST: RiskLevel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RiskLevelModel riskLevelModel = db.RiskLevelModel.Find(id);
            db.RiskLevelModel.Remove(riskLevelModel);
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

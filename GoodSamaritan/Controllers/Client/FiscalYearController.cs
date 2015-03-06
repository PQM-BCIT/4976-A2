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
    public class FiscalYearController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: FiscalYear
        public ActionResult Index()
        {
            return View(db.FiscalYearModel.ToList());
        }

        // GET: FiscalYear/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FiscalYearModel fiscalYearModel = db.FiscalYearModel.Find(id);
            if (fiscalYearModel == null)
            {
                return HttpNotFound();
            }
            return View(fiscalYearModel);
        }

        // GET: FiscalYear/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FiscalYear/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FiscalYearId,FiscalYear")] FiscalYearModel fiscalYearModel)
        {
            if (ModelState.IsValid)
            {
                db.FiscalYearModel.Add(fiscalYearModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fiscalYearModel);
        }

        // GET: FiscalYear/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FiscalYearModel fiscalYearModel = db.FiscalYearModel.Find(id);
            if (fiscalYearModel == null)
            {
                return HttpNotFound();
            }
            return View(fiscalYearModel);
        }

        // POST: FiscalYear/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FiscalYearId,FiscalYear")] FiscalYearModel fiscalYearModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fiscalYearModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fiscalYearModel);
        }

        // GET: FiscalYear/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FiscalYearModel fiscalYearModel = db.FiscalYearModel.Find(id);
            if (fiscalYearModel == null)
            {
                return HttpNotFound();
            }
            return View(fiscalYearModel);
        }

        // POST: FiscalYear/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FiscalYearModel fiscalYearModel = db.FiscalYearModel.Find(id);
            db.FiscalYearModel.Remove(fiscalYearModel);
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

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
    public class EvidenceStoredController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: EvidenceStored
        public ActionResult Index()
        {
            return View(db.EvidenceStoredModel.ToList());
        }

        // GET: EvidenceStored/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStoredModel evidenceStoredModel = db.EvidenceStoredModel.Find(id);
            if (evidenceStoredModel == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStoredModel);
        }

        // GET: EvidenceStored/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EvidenceStored/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvidenceStoredId,EvidenceStored")] EvidenceStoredModel evidenceStoredModel)
        {
            if (ModelState.IsValid)
            {
                db.EvidenceStoredModel.Add(evidenceStoredModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evidenceStoredModel);
        }

        // GET: EvidenceStored/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStoredModel evidenceStoredModel = db.EvidenceStoredModel.Find(id);
            if (evidenceStoredModel == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStoredModel);
        }

        // POST: EvidenceStored/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvidenceStoredId,EvidenceStored")] EvidenceStoredModel evidenceStoredModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evidenceStoredModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evidenceStoredModel);
        }

        // GET: EvidenceStored/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStoredModel evidenceStoredModel = db.EvidenceStoredModel.Find(id);
            if (evidenceStoredModel == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStoredModel);
        }

        // POST: EvidenceStored/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EvidenceStoredModel evidenceStoredModel = db.EvidenceStoredModel.Find(id);
            db.EvidenceStoredModel.Remove(evidenceStoredModel);
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

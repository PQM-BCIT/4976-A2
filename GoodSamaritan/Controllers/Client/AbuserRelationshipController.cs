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
    public class AbuserRelationshipController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: AbuserRelationship
        public ActionResult Index()
        {
            return View(db.AbuserRelationshipModel.ToList());
        }

        // GET: AbuserRelationship/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationshipModel abuserRelationshipModel = db.AbuserRelationshipModel.Find(id);
            if (abuserRelationshipModel == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationshipModel);
        }

        // GET: AbuserRelationship/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbuserRelationship/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AbuserRelationshipId,AbuserRelationship")] AbuserRelationshipModel abuserRelationshipModel)
        {
            if (ModelState.IsValid)
            {
                db.AbuserRelationshipModel.Add(abuserRelationshipModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(abuserRelationshipModel);
        }

        // GET: AbuserRelationship/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationshipModel abuserRelationshipModel = db.AbuserRelationshipModel.Find(id);
            if (abuserRelationshipModel == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationshipModel);
        }

        // POST: AbuserRelationship/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AbuserRelationshipId,AbuserRelationship")] AbuserRelationshipModel abuserRelationshipModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abuserRelationshipModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abuserRelationshipModel);
        }

        // GET: AbuserRelationship/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationshipModel abuserRelationshipModel = db.AbuserRelationshipModel.Find(id);
            if (abuserRelationshipModel == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationshipModel);
        }

        // POST: AbuserRelationship/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AbuserRelationshipModel abuserRelationshipModel = db.AbuserRelationshipModel.Find(id);
            db.AbuserRelationshipModel.Remove(abuserRelationshipModel);
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

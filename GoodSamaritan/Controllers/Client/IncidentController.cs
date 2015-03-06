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
    public class IncidentController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Incident
        public ActionResult Index()
        {
            return View(db.IncidentModel.ToList());
        }

        // GET: Incident/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentModel incidentModel = db.IncidentModel.Find(id);
            if (incidentModel == null)
            {
                return HttpNotFound();
            }
            return View(incidentModel);
        }

        // GET: Incident/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Incident/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IncidentId,Incident")] IncidentModel incidentModel)
        {
            if (ModelState.IsValid)
            {
                db.IncidentModel.Add(incidentModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incidentModel);
        }

        // GET: Incident/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentModel incidentModel = db.IncidentModel.Find(id);
            if (incidentModel == null)
            {
                return HttpNotFound();
            }
            return View(incidentModel);
        }

        // POST: Incident/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IncidentId,Incident")] IncidentModel incidentModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incidentModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incidentModel);
        }

        // GET: Incident/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentModel incidentModel = db.IncidentModel.Find(id);
            if (incidentModel == null)
            {
                return HttpNotFound();
            }
            return View(incidentModel);
        }

        // POST: Incident/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncidentModel incidentModel = db.IncidentModel.Find(id);
            db.IncidentModel.Remove(incidentModel);
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

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
    public class VictimOfIncidentController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: VictimOfIncident
        public ActionResult Index()
        {
            return View(db.VictimOfIncidentModel.ToList());
        }

        // GET: VictimOfIncident/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncidentModel victimOfIncidentModel = db.VictimOfIncidentModel.Find(id);
            if (victimOfIncidentModel == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncidentModel);
        }

        // GET: VictimOfIncident/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimOfIncident/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VictimOfIncidentId,VictimOfIncident")] VictimOfIncidentModel victimOfIncidentModel)
        {
            if (ModelState.IsValid)
            {
                db.VictimOfIncidentModel.Add(victimOfIncidentModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(victimOfIncidentModel);
        }

        // GET: VictimOfIncident/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncidentModel victimOfIncidentModel = db.VictimOfIncidentModel.Find(id);
            if (victimOfIncidentModel == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncidentModel);
        }

        // POST: VictimOfIncident/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VictimOfIncidentId,VictimOfIncident")] VictimOfIncidentModel victimOfIncidentModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimOfIncidentModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(victimOfIncidentModel);
        }

        // GET: VictimOfIncident/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncidentModel victimOfIncidentModel = db.VictimOfIncidentModel.Find(id);
            if (victimOfIncidentModel == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncidentModel);
        }

        // POST: VictimOfIncident/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VictimOfIncidentModel victimOfIncidentModel = db.VictimOfIncidentModel.Find(id);
            db.VictimOfIncidentModel.Remove(victimOfIncidentModel);
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

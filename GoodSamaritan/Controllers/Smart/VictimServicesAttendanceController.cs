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
    public class VictimServicesAttendanceController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: VictimServicesAttendance
        public ActionResult Index()
        {
            return View(db.VictimServicesAttendanceModel.ToList());
        }

        // GET: VictimServicesAttendance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesAttendanceModel victimServicesAttendanceModel = db.VictimServicesAttendanceModel.Find(id);
            if (victimServicesAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesAttendanceModel);
        }

        // GET: VictimServicesAttendance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimServicesAttendance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VictimServicesAttendanceId,VictimServicesAttendance")] VictimServicesAttendanceModel victimServicesAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.VictimServicesAttendanceModel.Add(victimServicesAttendanceModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(victimServicesAttendanceModel);
        }

        // GET: VictimServicesAttendance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesAttendanceModel victimServicesAttendanceModel = db.VictimServicesAttendanceModel.Find(id);
            if (victimServicesAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesAttendanceModel);
        }

        // POST: VictimServicesAttendance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VictimServicesAttendanceId,VictimServicesAttendance")] VictimServicesAttendanceModel victimServicesAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimServicesAttendanceModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(victimServicesAttendanceModel);
        }

        // GET: VictimServicesAttendance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesAttendanceModel victimServicesAttendanceModel = db.VictimServicesAttendanceModel.Find(id);
            if (victimServicesAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesAttendanceModel);
        }

        // POST: VictimServicesAttendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VictimServicesAttendanceModel victimServicesAttendanceModel = db.VictimServicesAttendanceModel.Find(id);
            db.VictimServicesAttendanceModel.Remove(victimServicesAttendanceModel);
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

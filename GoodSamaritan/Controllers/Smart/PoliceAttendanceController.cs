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
    public class PoliceAttendanceController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: PoliceAttendance
        public ActionResult Index()
        {
            return View(db.PoliceAttendanceModel.ToList());
        }

        // GET: PoliceAttendance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendanceModel policeAttendanceModel = db.PoliceAttendanceModel.Find(id);
            if (policeAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendanceModel);
        }

        // GET: PoliceAttendance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceAttendance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PoliceAttendanceId,PoliceAttendance")] PoliceAttendanceModel policeAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.PoliceAttendanceModel.Add(policeAttendanceModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(policeAttendanceModel);
        }

        // GET: PoliceAttendance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendanceModel policeAttendanceModel = db.PoliceAttendanceModel.Find(id);
            if (policeAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendanceModel);
        }

        // POST: PoliceAttendance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PoliceAttendanceId,PoliceAttendance")] PoliceAttendanceModel policeAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeAttendanceModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policeAttendanceModel);
        }

        // GET: PoliceAttendance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendanceModel policeAttendanceModel = db.PoliceAttendanceModel.Find(id);
            if (policeAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendanceModel);
        }

        // POST: PoliceAttendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PoliceAttendanceModel policeAttendanceModel = db.PoliceAttendanceModel.Find(id);
            db.PoliceAttendanceModel.Remove(policeAttendanceModel);
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

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
    public class HospitalAttendedController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: HospitalAttended
        public ActionResult Index()
        {
            return View(db.HospitalAttendedModel.ToList());
        }

        // GET: HospitalAttended/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttendedModel hospitalAttendedModel = db.HospitalAttendedModel.Find(id);
            if (hospitalAttendedModel == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttendedModel);
        }

        // GET: HospitalAttended/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalAttended/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HospitalAttendedId,HospitalAttended")] HospitalAttendedModel hospitalAttendedModel)
        {
            if (ModelState.IsValid)
            {
                db.HospitalAttendedModel.Add(hospitalAttendedModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospitalAttendedModel);
        }

        // GET: HospitalAttended/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttendedModel hospitalAttendedModel = db.HospitalAttendedModel.Find(id);
            if (hospitalAttendedModel == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttendedModel);
        }

        // POST: HospitalAttended/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HospitalAttendedId,HospitalAttended")] HospitalAttendedModel hospitalAttendedModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalAttendedModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospitalAttendedModel);
        }

        // GET: HospitalAttended/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttendedModel hospitalAttendedModel = db.HospitalAttendedModel.Find(id);
            if (hospitalAttendedModel == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttendedModel);
        }

        // POST: HospitalAttended/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HospitalAttendedModel hospitalAttendedModel = db.HospitalAttendedModel.Find(id);
            db.HospitalAttendedModel.Remove(hospitalAttendedModel);
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

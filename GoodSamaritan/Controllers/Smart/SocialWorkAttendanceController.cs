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
    public class SocialWorkAttendanceController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: SocialWorkAttendance
        public ActionResult Index()
        {
            return View(db.SocialWorkAttendanceModel.ToList());
        }

        // GET: SocialWorkAttendance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendanceModel socialWorkAttendanceModel = db.SocialWorkAttendanceModel.Find(id);
            if (socialWorkAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendanceModel);
        }

        // GET: SocialWorkAttendance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialWorkAttendance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SocialWorkAttendanceId,SocialWorkAttendance")] SocialWorkAttendanceModel socialWorkAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.SocialWorkAttendanceModel.Add(socialWorkAttendanceModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(socialWorkAttendanceModel);
        }

        // GET: SocialWorkAttendance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendanceModel socialWorkAttendanceModel = db.SocialWorkAttendanceModel.Find(id);
            if (socialWorkAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendanceModel);
        }

        // POST: SocialWorkAttendance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SocialWorkAttendanceId,SocialWorkAttendance")] SocialWorkAttendanceModel socialWorkAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socialWorkAttendanceModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socialWorkAttendanceModel);
        }

        // GET: SocialWorkAttendance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendanceModel socialWorkAttendanceModel = db.SocialWorkAttendanceModel.Find(id);
            if (socialWorkAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendanceModel);
        }

        // POST: SocialWorkAttendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SocialWorkAttendanceModel socialWorkAttendanceModel = db.SocialWorkAttendanceModel.Find(id);
            db.SocialWorkAttendanceModel.Remove(socialWorkAttendanceModel);
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

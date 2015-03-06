using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;

namespace GoodSamaritan.Controllers.Client
{
    public class AssignedWorkerController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: AssignedWorker
        public ActionResult Index()
        {
            return View(db.AssignedWorkerModel.ToList());
        }

        // GET: AssignedWorker/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorkerModel assignedWorkerModel = db.AssignedWorkerModel.Find(id);
            if (assignedWorkerModel == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorkerModel);
        }

        // GET: AssignedWorker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssignedWorker/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignedWorkerId,AssignedWorker")] AssignedWorkerModel assignedWorkerModel)
        {
            if (ModelState.IsValid)
            {
                db.AssignedWorkerModel.Add(assignedWorkerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assignedWorkerModel);
        }

        // GET: AssignedWorker/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorkerModel assignedWorkerModel = db.AssignedWorkerModel.Find(id);
            if (assignedWorkerModel == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorkerModel);
        }

        // POST: AssignedWorker/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignedWorkerId,AssignedWorker")] AssignedWorkerModel assignedWorkerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignedWorkerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assignedWorkerModel);
        }

        // GET: AssignedWorker/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorkerModel assignedWorkerModel = db.AssignedWorkerModel.Find(id);
            if (assignedWorkerModel == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorkerModel);
        }

        // POST: AssignedWorker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssignedWorkerModel assignedWorkerModel = db.AssignedWorkerModel.Find(id);
            db.AssignedWorkerModel.Remove(assignedWorkerModel);
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

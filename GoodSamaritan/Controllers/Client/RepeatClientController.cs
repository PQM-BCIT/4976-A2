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
    public class RepeatClientController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: RepeatClient
        public ActionResult Index()
        {
            return View(db.RepeatClientModel.ToList());
        }

        // GET: RepeatClient/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClientModel repeatClientModel = db.RepeatClientModel.Find(id);
            if (repeatClientModel == null)
            {
                return HttpNotFound();
            }
            return View(repeatClientModel);
        }

        // GET: RepeatClient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepeatClient/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RepeatClientId,RepeatClient")] RepeatClientModel repeatClientModel)
        {
            if (ModelState.IsValid)
            {
                db.RepeatClientModel.Add(repeatClientModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repeatClientModel);
        }

        // GET: RepeatClient/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClientModel repeatClientModel = db.RepeatClientModel.Find(id);
            if (repeatClientModel == null)
            {
                return HttpNotFound();
            }
            return View(repeatClientModel);
        }

        // POST: RepeatClient/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RepeatClientId,RepeatClient")] RepeatClientModel repeatClientModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repeatClientModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repeatClientModel);
        }

        // GET: RepeatClient/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClientModel repeatClientModel = db.RepeatClientModel.Find(id);
            if (repeatClientModel == null)
            {
                return HttpNotFound();
            }
            return View(repeatClientModel);
        }

        // POST: RepeatClient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RepeatClientModel repeatClientModel = db.RepeatClientModel.Find(id);
            db.RepeatClientModel.Remove(repeatClientModel);
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

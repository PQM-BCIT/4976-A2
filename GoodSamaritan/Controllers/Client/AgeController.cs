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
    public class AgeController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Age
        public ActionResult Index()
        {
            return View(db.AgeModel.ToList());
        }

        // GET: Age/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgeModel ageModel = db.AgeModel.Find(id);
            if (ageModel == null)
            {
                return HttpNotFound();
            }
            return View(ageModel);
        }

        // GET: Age/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Age/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgeId,Age")] AgeModel ageModel)
        {
            if (ModelState.IsValid)
            {
                db.AgeModel.Add(ageModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ageModel);
        }

        // GET: Age/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgeModel ageModel = db.AgeModel.Find(id);
            if (ageModel == null)
            {
                return HttpNotFound();
            }
            return View(ageModel);
        }

        // POST: Age/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgeId,Age")] AgeModel ageModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ageModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ageModel);
        }

        // GET: Age/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgeModel ageModel = db.AgeModel.Find(id);
            if (ageModel == null)
            {
                return HttpNotFound();
            }
            return View(ageModel);
        }

        // POST: Age/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgeModel ageModel = db.AgeModel.Find(id);
            db.AgeModel.Remove(ageModel);
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

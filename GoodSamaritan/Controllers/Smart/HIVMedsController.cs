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
    public class HIVMedsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: HIVMeds
        public ActionResult Index()
        {
            return View(db.HIVMedsModel.ToList());
        }

        // GET: HIVMeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HIVMedsModel hIVMedsModel = db.HIVMedsModel.Find(id);
            if (hIVMedsModel == null)
            {
                return HttpNotFound();
            }
            return View(hIVMedsModel);
        }

        // GET: HIVMeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HIVMeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HIVMedsId,HIVMeds")] HIVMedsModel hIVMedsModel)
        {
            if (ModelState.IsValid)
            {
                db.HIVMedsModel.Add(hIVMedsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hIVMedsModel);
        }

        // GET: HIVMeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HIVMedsModel hIVMedsModel = db.HIVMedsModel.Find(id);
            if (hIVMedsModel == null)
            {
                return HttpNotFound();
            }
            return View(hIVMedsModel);
        }

        // POST: HIVMeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HIVMedsId,HIVMeds")] HIVMedsModel hIVMedsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hIVMedsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hIVMedsModel);
        }

        // GET: HIVMeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HIVMedsModel hIVMedsModel = db.HIVMedsModel.Find(id);
            if (hIVMedsModel == null)
            {
                return HttpNotFound();
            }
            return View(hIVMedsModel);
        }

        // POST: HIVMeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HIVMedsModel hIVMedsModel = db.HIVMedsModel.Find(id);
            db.HIVMedsModel.Remove(hIVMedsModel);
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

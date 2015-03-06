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
    public class DrugFacilitatedAssaultController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: DrugFacilitatedAssault
        public ActionResult Index()
        {
            return View(db.DrugFacilitatedAssaultModel.ToList());
        }

        // GET: DrugFacilitatedAssault/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = db.DrugFacilitatedAssaultModel.Find(id);
            if (drugFacilitatedAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssaultModel);
        }

        // GET: DrugFacilitatedAssault/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrugFacilitatedAssault/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DrugFacilitatedAssaultId,DrugFacilitatedAssault")] DrugFacilitatedAssaultModel drugFacilitatedAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.DrugFacilitatedAssaultModel.Add(drugFacilitatedAssaultModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drugFacilitatedAssaultModel);
        }

        // GET: DrugFacilitatedAssault/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = db.DrugFacilitatedAssaultModel.Find(id);
            if (drugFacilitatedAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssaultModel);
        }

        // POST: DrugFacilitatedAssault/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DrugFacilitatedAssaultId,DrugFacilitatedAssault")] DrugFacilitatedAssaultModel drugFacilitatedAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drugFacilitatedAssaultModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drugFacilitatedAssaultModel);
        }

        // GET: DrugFacilitatedAssault/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = db.DrugFacilitatedAssaultModel.Find(id);
            if (drugFacilitatedAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssaultModel);
        }

        // POST: DrugFacilitatedAssault/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = db.DrugFacilitatedAssaultModel.Find(id);
            db.DrugFacilitatedAssaultModel.Remove(drugFacilitatedAssaultModel);
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

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
    public class CityOfResidenceController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: CityOfResidence
        public ActionResult Index()
        {
            return View(db.CityOfResidenceModel.ToList());
        }

        // GET: CityOfResidence/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidenceModel cityOfResidenceModel = db.CityOfResidenceModel.Find(id);
            if (cityOfResidenceModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidenceModel);
        }

        // GET: CityOfResidence/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfResidence/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityOfResidenceId,CityOfResidence")] CityOfResidenceModel cityOfResidenceModel)
        {
            if (ModelState.IsValid)
            {
                db.CityOfResidenceModel.Add(cityOfResidenceModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cityOfResidenceModel);
        }

        // GET: CityOfResidence/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidenceModel cityOfResidenceModel = db.CityOfResidenceModel.Find(id);
            if (cityOfResidenceModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidenceModel);
        }

        // POST: CityOfResidence/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityOfResidenceId,CityOfResidence")] CityOfResidenceModel cityOfResidenceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfResidenceModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cityOfResidenceModel);
        }

        // GET: CityOfResidence/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidenceModel cityOfResidenceModel = db.CityOfResidenceModel.Find(id);
            if (cityOfResidenceModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidenceModel);
        }

        // POST: CityOfResidence/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CityOfResidenceModel cityOfResidenceModel = db.CityOfResidenceModel.Find(id);
            db.CityOfResidenceModel.Remove(cityOfResidenceModel);
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

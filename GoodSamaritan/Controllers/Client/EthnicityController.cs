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
    public class EthnicityController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Ethnicity
        public ActionResult Index()
        {
            return View(db.EthnicityModel.ToList());
        }

        // GET: Ethnicity/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EthnicityModel ethnicityModel = db.EthnicityModel.Find(id);
            if (ethnicityModel == null)
            {
                return HttpNotFound();
            }
            return View(ethnicityModel);
        }

        // GET: Ethnicity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ethnicity/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EthnicityId,Ethnicity")] EthnicityModel ethnicityModel)
        {
            if (ModelState.IsValid)
            {
                db.EthnicityModel.Add(ethnicityModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ethnicityModel);
        }

        // GET: Ethnicity/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EthnicityModel ethnicityModel = db.EthnicityModel.Find(id);
            if (ethnicityModel == null)
            {
                return HttpNotFound();
            }
            return View(ethnicityModel);
        }

        // POST: Ethnicity/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EthnicityId,Ethnicity")] EthnicityModel ethnicityModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ethnicityModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ethnicityModel);
        }

        // GET: Ethnicity/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EthnicityModel ethnicityModel = db.EthnicityModel.Find(id);
            if (ethnicityModel == null)
            {
                return HttpNotFound();
            }
            return View(ethnicityModel);
        }

        // POST: Ethnicity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EthnicityModel ethnicityModel = db.EthnicityModel.Find(id);
            db.EthnicityModel.Remove(ethnicityModel);
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

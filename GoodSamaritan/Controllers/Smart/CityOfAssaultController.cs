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
    public class CityOfAssaultController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: CityOfAssault
        public ActionResult Index()
        {
            return View(db.CityOfAssaultModel.ToList());
        }

        // GET: CityOfAssault/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssaultModel cityOfAssaultModel = db.CityOfAssaultModel.Find(id);
            if (cityOfAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssaultModel);
        }

        // GET: CityOfAssault/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfAssault/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityOfAssaultId,CityOfAssault")] CityOfAssaultModel cityOfAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.CityOfAssaultModel.Add(cityOfAssaultModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cityOfAssaultModel);
        }

        // GET: CityOfAssault/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssaultModel cityOfAssaultModel = db.CityOfAssaultModel.Find(id);
            if (cityOfAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssaultModel);
        }

        // POST: CityOfAssault/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityOfAssaultId,CityOfAssault")] CityOfAssaultModel cityOfAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfAssaultModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cityOfAssaultModel);
        }

        // GET: CityOfAssault/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssaultModel cityOfAssaultModel = db.CityOfAssaultModel.Find(id);
            if (cityOfAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssaultModel);
        }

        // POST: CityOfAssault/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CityOfAssaultModel cityOfAssaultModel = db.CityOfAssaultModel.Find(id);
            db.CityOfAssaultModel.Remove(cityOfAssaultModel);
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

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
    public class ProgramController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Program
        public ActionResult Index()
        {
            return View(db.ProgramModel.ToList());
        }

        // GET: Program/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramModel programModel = db.ProgramModel.Find(id);
            if (programModel == null)
            {
                return HttpNotFound();
            }
            return View(programModel);
        }

        // GET: Program/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Program/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProgramId,Program")] ProgramModel programModel)
        {
            if (ModelState.IsValid)
            {
                db.ProgramModel.Add(programModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(programModel);
        }

        // GET: Program/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramModel programModel = db.ProgramModel.Find(id);
            if (programModel == null)
            {
                return HttpNotFound();
            }
            return View(programModel);
        }

        // POST: Program/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProgramId,Program")] ProgramModel programModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(programModel);
        }

        // GET: Program/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramModel programModel = db.ProgramModel.Find(id);
            if (programModel == null)
            {
                return HttpNotFound();
            }
            return View(programModel);
        }

        // POST: Program/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProgramModel programModel = db.ProgramModel.Find(id);
            db.ProgramModel.Remove(programModel);
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

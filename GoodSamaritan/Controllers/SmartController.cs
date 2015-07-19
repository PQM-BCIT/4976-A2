using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;
using GoodSamaritan.Models.SmartEntity;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker")]
    public class SmartController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Smart
        public async Task<ActionResult> Index()
        {
            var smartModel = db.SmartModel.Include(s => s.BadDateReport).Include(s => s.CityOfAssault).Include(s => s.CityOfResidence).Include(s => s.DrugFacilitatedAssault).Include(s => s.EvidenceStored).Include(s => s.HIVMeds).Include(s => s.HospitalAttended).Include(s => s.MedicalOnly).Include(s => s.MultiplePerpetrators).Include(s => s.PoliceAttendance).Include(s => s.PoliceReported).Include(s => s.ReferredToCBVS).Include(s => s.ReferringHospital).Include(s => s.SexWorkExploitation).Include(s => s.SocialWorkAttendance).Include(s => s.ThirdPartyReport).Include(s => s.VictimServicesAttendance);
            return View(await smartModel.ToListAsync());
        }

        // GET: Smart/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            if (smartModel == null)
            {
                return HttpNotFound();
            }
            return View(smartModel);
        }

        // GET: Smart/Create
        public ActionResult Create()
        {
            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport");
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault");
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence");
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault");
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored");
            ViewBag.HIVMedsModelId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds");
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended");
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly");
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsId", "MultiplePerpetrators");
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PoliceAttendance");
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PoliceReported");
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVSModel, "ReferredToCBVSId", "ReferredToCBVS");
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitalModel, "ReferringHospitalId", "ReferringHospital");
            ViewBag.SexWorkerExploitationId = new SelectList(db.SexWorkerExploitationModel, "SexWorkerExploitationId", "SexWorkerExploitation");
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocialWorkAttendanceId", "SocialWorkAttendance");
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportId", "ThirdPartyReport");
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendanceModel, "VictimServicesAttendanceId", "VictimServicesAttendance");
            return View();
        }

        // POST: Smart/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ClientReferenceNumber,SexWorkerExploitationId,MultiplePerpetratorsId,DrugFacilitatedAssaultId,CityOfAssaultId,CityOfResidenceId,AccompanimentMinute,ReferringHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceId,VictimServicesAttendanceId,MedicalOnlyId,EvidenceStoredId,HIVMedsModelId,ReferredToCBVSId,PoliceReportedId,ThirdPartyReportId,BadDateReportId,NumberTransportsProvided,ReferredToNursePractitioner")] SmartModel smartModel)
        {
            if (ModelState.IsValid)
            {
                db.SmartModel.Add(smartModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smartModel.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smartModel.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smartModel.CityOfResidenceId);
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smartModel.DrugFacilitatedAssaultId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smartModel.EvidenceStoredId);
            ViewBag.HIVMedsModelId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smartModel.HIVMedsModelId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smartModel.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smartModel.MedicalOnlyId);
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsId", "MultiplePerpetrators", smartModel.MultiplePerpetratorsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PoliceAttendance", smartModel.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PoliceReported", smartModel.PoliceReportedId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVSModel, "ReferredToCBVSId", "ReferredToCBVS", smartModel.ReferredToCBVSId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitalModel, "ReferringHospitalId", "ReferringHospital", smartModel.ReferringHospitalId);
            ViewBag.SexWorkerExploitationId = new SelectList(db.SexWorkerExploitationModel, "SexWorkerExploitationId", "SexWorkerExploitation", smartModel.SexWorkerExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocialWorkAttendanceId", "SocialWorkAttendance", smartModel.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportId", "ThirdPartyReport", smartModel.ThirdPartyReportId);
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendanceModel, "VictimServicesAttendanceId", "VictimServicesAttendance", smartModel.VictimServicesAttendanceId);
            return View(smartModel);
        }

        // GET: Smart/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            if (smartModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smartModel.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smartModel.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smartModel.CityOfResidenceId);
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smartModel.DrugFacilitatedAssaultId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smartModel.EvidenceStoredId);
            ViewBag.HIVMedsModelId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smartModel.HIVMedsModelId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smartModel.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smartModel.MedicalOnlyId);
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsId", "MultiplePerpetrators", smartModel.MultiplePerpetratorsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PoliceAttendance", smartModel.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PoliceReported", smartModel.PoliceReportedId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVSModel, "ReferredToCBVSId", "ReferredToCBVS", smartModel.ReferredToCBVSId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitalModel, "ReferringHospitalId", "ReferringHospital", smartModel.ReferringHospitalId);
            ViewBag.SexWorkerExploitationId = new SelectList(db.SexWorkerExploitationModel, "SexWorkerExploitationId", "SexWorkerExploitation", smartModel.SexWorkerExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocialWorkAttendanceId", "SocialWorkAttendance", smartModel.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportId", "ThirdPartyReport", smartModel.ThirdPartyReportId);
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendanceModel, "VictimServicesAttendanceId", "VictimServicesAttendance", smartModel.VictimServicesAttendanceId);
            return View(smartModel);
        }

        // POST: Smart/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ClientReferenceNumber,SexWorkerExploitationId,MultiplePerpetratorsId,DrugFacilitatedAssaultId,CityOfAssaultId,CityOfResidenceId,AccompanimentMinute,ReferringHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceId,VictimServicesAttendanceId,MedicalOnlyId,EvidenceStoredId,HIVMedsModelId,ReferredToCBVSId,PoliceReportedId,ThirdPartyReportId,BadDateReportId,NumberTransportsProvided,ReferredToNursePractitioner")] SmartModel smartModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smartModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smartModel.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smartModel.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smartModel.CityOfResidenceId);
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smartModel.DrugFacilitatedAssaultId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smartModel.EvidenceStoredId);
            ViewBag.HIVMedsModelId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smartModel.HIVMedsModelId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smartModel.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smartModel.MedicalOnlyId);
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsId", "MultiplePerpetrators", smartModel.MultiplePerpetratorsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PoliceAttendance", smartModel.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PoliceReported", smartModel.PoliceReportedId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVSModel, "ReferredToCBVSId", "ReferredToCBVS", smartModel.ReferredToCBVSId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitalModel, "ReferringHospitalId", "ReferringHospital", smartModel.ReferringHospitalId);
            ViewBag.SexWorkerExploitationId = new SelectList(db.SexWorkerExploitationModel, "SexWorkerExploitationId", "SexWorkerExploitation", smartModel.SexWorkerExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocialWorkAttendanceId", "SocialWorkAttendance", smartModel.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportId", "ThirdPartyReport", smartModel.ThirdPartyReportId);
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendanceModel, "VictimServicesAttendanceId", "VictimServicesAttendance", smartModel.VictimServicesAttendanceId);
            return View(smartModel);
        }

        // GET: Smart/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            if (smartModel == null)
            {
                return HttpNotFound();
            }
            return View(smartModel);
        }

        // POST: Smart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            db.SmartModel.Remove(smartModel);
            await db.SaveChangesAsync();
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

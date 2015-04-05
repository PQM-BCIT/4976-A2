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
using System.Diagnostics;

namespace GoodSamaritan.Controllers
{
    public class ClientController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Client
        public async Task<ActionResult> Index()
        {
            var clientModel = db.ClientModel.Include(c => c.AbuserRealtionship).Include(c => c.Age).Include(c => c.AssignedWorker).Include(c => c.Crisis).Include(c => c.DuplicateFile).Include(c => c.Ethnicity).Include(c => c.FamilyViolenceFile).Include(c => c.FiscalYear).Include(c => c.Incident).Include(c => c.Program).Include(c => c.ReferralSource).Include(c => c.RepeatClient).Include(c => c.RiskLevel).Include(c => c.RiskStatus).Include(c => c.Service).Include(c => c.SmartModel).Include(c => c.StatusOfFile).Include(c => c.VictimOfIncident);
            return View(await clientModel.ToListAsync());
        }

        // GET: Client/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            return View(clientModel);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationshipId", "AbuserRelationship");
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age");
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker");
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis");
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile");
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity");
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFileModel, "FamilyViolenceFileId", "FamilyViolenceFile");
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FiscalYearId", "FiscalYear");
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident");
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program");
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceMode, "ReferralSourceId", "ReferralSource");
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient");
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel");
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus");
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service");
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber");
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile");
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOfIncidentId", "VictimOfIncident");

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

        // POST: Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ClientReferenceNumber,FiscalYearId,Month,Day,Surname,FirstName,PoliceFileNumber,CourtFileNumber,SwcFileNumber,RiskLevelId,CrisisId,ServiceId,ProgramId,RiskAssessmentAssignedTo,RiskStatusId,AssignedWorkerId,ReferralSourceId,IncidentId,AbuserSurnameName,AbuserFirstName,AbuserRelationshipId,VictimOfIncidentId,FamilyViolenceFileId,Gender,EthnicityId,AgeId,RepeatClientId,DuplicateFileId,NumberOfChildren0To6,NumberOfChildren7To12,NumberOfChildren13To18,StatusOfFileId,DateLastTransferred,DateClosed,DateReOpened")] ClientModel clientModel, FormCollection smartModel)
        {
            SmartModel smart = new SmartModel();
            if (ModelState.IsValid)
            {
                if (clientModel.ProgramId == 3)
                {
                    smart.SexWorkerExploitationId = Convert.ToInt32(smartModel["SexWorkerExploitationId"]);
                    smart.MultiplePerpetratorsId = Convert.ToInt32(smartModel["MultiplePerpetratorsId"]);
                    smart.DrugFacilitatedAssaultId = Convert.ToInt32(smartModel["DrugFacilitatedAssaultId"]);
                    smart.CityOfAssaultId = Convert.ToInt32(smartModel["CityOfAssaultId"]);
                    smart.CityOfResidenceId = Convert.ToInt32(smartModel["CityOfResidenceId"]);
                    smart.AccompanimentMinute = Convert.ToInt32(smartModel["AccompanimentMinute"]);
                    smart.ReferringHospitalId = Convert.ToInt32(smartModel["ReferringHospitalId"]);
                    smart.HospitalAttendedId = Convert.ToInt32(smartModel["HospitalAttendedId"]);
                    smart.SocialWorkAttendanceId = Convert.ToInt32(smartModel["SocialWorkAttendanceId"]);
                    smart.PoliceAttendanceId = Convert.ToInt32(smartModel["PoliceAttendanceId"]);
                    smart.VictimServicesAttendanceId = Convert.ToInt32(smartModel["VictimServicesAttendanceId"]);
                    smart.MedicalOnlyId = Convert.ToInt32(smartModel["MedicalOnlyId"]);
                    smart.EvidenceStoredId = Convert.ToInt32(smartModel["EvidenceStoredId"]);
                    smart.HIVMedsModelId = Convert.ToInt32(smartModel["HIVMedsModelId"]);
                    smart.ReferredToCBVSId = Convert.ToInt32(smartModel["ReferredToCBVSId"]);
                    smart.PoliceReportedId = Convert.ToInt32(smartModel["PoliceReportedId"]);
                    smart.ThirdPartyReportId = Convert.ToInt32(smartModel["ThirdPartyReportId"]);
                    smart.BadDateReportId = Convert.ToInt32(smartModel["BadDateReportId"]);
                    smart.NumberTransportsProvided = Convert.ToInt32(smartModel["NumberTransportsProvided"]);
                    smart.ReferredToNursePractitioner = Convert.ToBoolean(smartModel["ReferredToNursePractitione"]);

                    db.SmartModel.Add(smart);
                    db.SaveChanges();
                    clientModel.ClientReferenceNumber = smart.ClientReferenceNumber;
                }
                else
                {

                    smart.SexWorkerExploitationId = 1;
                    smart.MultiplePerpetratorsId = 1;
                    smart.DrugFacilitatedAssaultId = 1;
                    smart.CityOfAssaultId = 1;
                    smart.CityOfResidenceId = 1;
                    smart.AccompanimentMinute = 1;
                    smart.ReferringHospitalId = 1;
                    smart.HospitalAttendedId = 1;
                    smart.SocialWorkAttendanceId = 1;
                    smart.PoliceAttendanceId = 1;
                    smart.VictimServicesAttendanceId = 1;
                    smart.MedicalOnlyId = 1;
                    smart.EvidenceStoredId = 1;
                    smart.HIVMedsModelId = 1;
                    smart.ReferredToCBVSId = 1;
                    smart.PoliceReportedId = 1;
                    smart.ThirdPartyReportId = 1;
                    smart.BadDateReportId = 1;
                    smart.NumberTransportsProvided = 1;
                    smart.ReferredToNursePractitioner = false;

                    db.SmartModel.Add(smart);
                    db.SaveChanges();
                    clientModel.ClientReferenceNumber = smart.ClientReferenceNumber;
                }

                db.ClientModel.Add(clientModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationshipId", "AbuserRelationship", clientModel.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age", clientModel.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker", clientModel.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis", clientModel.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile", clientModel.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity", clientModel.EthnicityId);
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFileModel, "FamilyViolenceFileId", "FamilyViolenceFile", clientModel.FamilyViolenceFileId);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FiscalYearId", "FiscalYear", clientModel.FiscalYearId);
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident", clientModel.IncidentId);
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program", clientModel.ProgramId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceMode, "ReferralSourceId", "ReferralSource", clientModel.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient", clientModel.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel", clientModel.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus", clientModel.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service", clientModel.ServiceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber", clientModel.ClientReferenceNumber);
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile", clientModel.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOfIncidentId", "VictimOfIncident", clientModel.VictimOfIncidentId);

            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smart.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smart.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smart.CityOfResidenceId);
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smart.DrugFacilitatedAssaultId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smart.EvidenceStoredId);
            ViewBag.HIVMedsModelId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smart.HIVMedsModelId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smart.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smart.MedicalOnlyId);
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsId", "MultiplePerpetrators", smart.MultiplePerpetratorsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PoliceAttendance", smart.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PoliceReported", smart.PoliceReportedId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVSModel, "ReferredToCBVSId", "ReferredToCBVS", smart.ReferredToCBVSId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitalModel, "ReferringHospitalId", "ReferringHospital", smart.ReferringHospitalId);
            ViewBag.SexWorkerExploitationId = new SelectList(db.SexWorkerExploitationModel, "SexWorkerExploitationId", "SexWorkerExploitation", smart.SexWorkerExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocialWorkAttendanceId", "SocialWorkAttendance", smart.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportId", "ThirdPartyReport", smart.ThirdPartyReportId);
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendanceModel, "VictimServicesAttendanceId", "VictimServicesAttendance", smart.VictimServicesAttendanceId);

            return View(clientModel);
        }

        // GET: Client/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationshipId", "AbuserRelationship", clientModel.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age", clientModel.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker", clientModel.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis", clientModel.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile", clientModel.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity", clientModel.EthnicityId);
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFileModel, "FamilyViolenceFileId", "FamilyViolenceFile", clientModel.FamilyViolenceFileId);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FiscalYearId", "FiscalYear", clientModel.FiscalYearId);
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident", clientModel.IncidentId);
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program", clientModel.ProgramId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceMode, "ReferralSourceId", "ReferralSource", clientModel.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient", clientModel.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel", clientModel.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus", clientModel.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service", clientModel.ServiceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber", clientModel.ClientReferenceNumber);
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile", clientModel.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOfIncidentId", "VictimOfIncident", clientModel.VictimOfIncidentId);
            return View(clientModel);
        }

        // POST: Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ClientReferenceNumber,FiscalYearId,Month,Day,Surname,FirstName,PoliceFileNumber,CourtFileNumber,SwcFileNumber,RiskLevelId,CrisisId,ServiceId,ProgramId,RiskAssessmentAssignedTo,RiskStatusId,AssignedWorkerId,ReferralSourceId,IncidentId,AbuserSurnameName,AbuserFirstName,AbuserRelationshipId,VictimOfIncidentId,FamilyViolenceFileId,Gender,EthnicityId,AgeId,RepeatClientId,DuplicateFileId,NumberOfChildren0To6,NumberOfChildren7To12,NumberOfChildren13To18,StatusOfFileId,DateLastTransferred,DateClosed,DateReOpened")] ClientModel clientModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationshipId", "AbuserRelationship", clientModel.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age", clientModel.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker", clientModel.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis", clientModel.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile", clientModel.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity", clientModel.EthnicityId);
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFileModel, "FamilyViolenceFileId", "FamilyViolenceFile", clientModel.FamilyViolenceFileId);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FiscalYearId", "FiscalYear", clientModel.FiscalYearId);
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident", clientModel.IncidentId);
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program", clientModel.ProgramId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceMode, "ReferralSourceId", "ReferralSource", clientModel.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient", clientModel.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel", clientModel.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus", clientModel.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service", clientModel.ServiceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber", clientModel.ClientReferenceNumber);
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile", clientModel.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOfIncidentId", "VictimOfIncident", clientModel.VictimOfIncidentId);
            return View(clientModel);
        }

        // GET: Client/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            return View(clientModel);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            db.ClientModel.Remove(clientModel);
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

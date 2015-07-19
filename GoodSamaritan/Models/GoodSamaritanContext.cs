using GoodSamaritan.Models.ClientEntity;
using GoodSamaritan.Models.SmartEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class GoodSamaritanContext : DbContext
    {
        public GoodSamaritanContext() : base("GoodSamaritanConnection")
        {
        }

        // Client
        public DbSet<ClientModel> ClientModel { get; set; }
        // Client Lookups
        public DbSet<AbuserRelationshipModel> AbuserRelationshipModel { get; set; }
        public DbSet<AgeModel> AgeModel { get; set; }
        public DbSet<AssignedWorkerModel> AssignedWorkerModel { get; set; }
        public DbSet<CrisisModel> CrisisModel { get; set; }
        public DbSet<DuplicateFileModel> DuplicateFileModel { get; set; }
        public DbSet<EthnicityModel> EthnicityModel { get; set; }
        public DbSet<FamilyViolenceFileModel> FamilyViolenceFileModel { get; set; }
        public DbSet<FiscalYearModel> FiscalYearModel { get; set; }
        public DbSet<IncidentModel> IncidentModel { get; set; }
        public DbSet<ProgramModel> ProgramModel { get; set; }
        public DbSet<ReferralContactModel> ReferralContactModel { get; set; }
        public DbSet<ReferralSourceModel> ReferralSourceMode { get; set; }
        public DbSet<RepeatClientModel> RepeatClientModel { get; set; }
        public DbSet<RiskLevelModel> RiskLevelModel { get; set; }
        public DbSet<RiskStatusModel> RiskStatusModel { get; set; }
        public DbSet<ServiceModel> ServiceModel { get; set; }
        public DbSet<StatusOfFileModel> StatusOfFileModel { get; set; }
        public DbSet<VictimOfIncidentModel> VictimOfIncidentModel { get; set; }

        // Smart
        public DbSet<SmartModel> SmartModel { get; set; }
        // Smart Lookups
        public DbSet<BadDateReportModel> BadDateReportModel { get; set; }
        public DbSet<CityOfAssaultModel> CityOfAssaultModel { get; set; }
        public DbSet<CityOfResidenceModel> CityOfResidenceModel { get; set; }
        public DbSet<DrugFacilitatedAssaultModel> DrugFacilitatedAssaultModel { get; set; }
        public DbSet<EvidenceStoredModel> EvidenceStoredModel { get; set; }
        public DbSet<HIVMedsModel> HIVMedsModel { get; set; }
        public DbSet<HospitalAttendedModel> HospitalAttendedModel { get; set; }
        public DbSet<MedicalOnlyModel> MedicalOnlyModel { get; set; }
        public DbSet<MultiplePerpetratorsModel> MultiplePerpetratorsModel { get; set; }
        public DbSet<PoliceAttendanceModel> PoliceAttendanceModel { get; set; }
        public DbSet<PoliceReportedModel> PoliceReportedModel { get; set; }
        public DbSet<ReferredToCBVSModel> ReferredToCBVSModel { get; set; }
        public DbSet<ReferringHospitalModel> ReferringHospitalModel { get; set; }
        public DbSet<SexWorkerExploitationModel> SexWorkerExploitationModel { get; set; }
        public DbSet<SocialWorkAttendanceModel> SocialWorkAttendanceModel { get; set; }
        public DbSet<ThirdPartyReportModel> ThirdPartyReportModel { get; set; }
        public DbSet<VictimServicesAttendanceModel> VictimServicesAttendanceModel { get; set; }
    }
}
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
        public GoodSamaritanContext() : base("DefaultConnection")
        {
        }

        // Client
        public virtual DbSet<ClientModel> ClientModel { get; set; }
        // Client Lookups
        public virtual DbSet<AbuserRelationshipModel> AbuserRelationshipModel { get; set; }
        public virtual DbSet<AgeModel> AgeModel { get; set; }
        public virtual DbSet<AssignedWorkerModel> AssignedWorkerModel { get; set; }
        public virtual DbSet<CrisisModel> CrisisModel { get; set; }
        public virtual DbSet<DuplicateFileModel> DuplicateFileModel { get; set; }
        public virtual DbSet<EthnicityModel> EthnicityModel { get; set; }
        public virtual DbSet<FamilyViolenceFileModel> FamilyViolenceFileModel { get; set; }
        public virtual DbSet<FiscalYearModel> FiscalYearModel { get; set; }
        public virtual DbSet<IncidentModel> IncidentModel { get; set; }
        public virtual DbSet<ProgramModel> ProgramModel { get; set; }
        public virtual DbSet<ReferralContactModel> ReferralContactModel { get; set; }
        public virtual DbSet<ReferralSourceModel> ReferralSourceMode { get; set; }
        public virtual DbSet<RepeatClientModel> RepeatClientModel { get; set; }
        public virtual DbSet<RiskLevelModel> RiskLevelModel { get; set; }
        public virtual DbSet<RiskStatusModel> RiskStatusModel { get; set; }
        public virtual DbSet<ServiceModel> ServiceModel { get; set; }
        public virtual DbSet<StatusOfFileModel> StatusOfFileModel { get; set; }
        public virtual DbSet<VictimOfIncidentModel> VictimOfIncidentModel { get; set; }

        // Smart
        public virtual DbSet<SmartModel> SmartModel { get; set; }
        // Smart Lookups
        public virtual DbSet<BadDateReportModel> BadDateReportModel { get; set; }
        public virtual DbSet<CityOfAssaultModel> CityOfAssaultModel { get; set; }
        public virtual DbSet<CityOfResidenceModel> CityOfResidenceModel { get; set; }
        public virtual DbSet<DrugFacilitatedAssaultModel> DrugFacilitatedAssaultModel { get; set; }
        public virtual DbSet<EvidenceStoredModel> EvidenceStoredModel { get; set; }
        public virtual DbSet<HIVMedsModel> HIVMedsModel { get; set; }
        public virtual DbSet<HospitalAttendedModel> HospitalAttendedModel { get; set; }
        public virtual DbSet<MedicalOnlyModel> MedicalOnlyModel { get; set; }
        public virtual DbSet<MultiplePerpetratorsModel> MultiplePerpetratorsModel { get; set; }
        public virtual DbSet<PoliceAttendanceModel> PoliceAttendanceModel { get; set; }
        public virtual DbSet<PoliceReportedModel> PoliceReportedModel { get; set; }
        public virtual DbSet<ReferredToCBVSModel> ReferredToCBVSModel { get; set; }
        public virtual DbSet<ReferringHospitalModel> ReferringHospitalModel { get; set; }
        public virtual DbSet<SexWorkExploitationModel> SexWorkExploitationModel { get; set; }
        public virtual DbSet<SocialWorkAttendanceModel> SocialWorkAttendanceModel { get; set; }
        public virtual DbSet<ThirdPartyReportModel> ThirdPartyReportModel { get; set; }
        public virtual DbSet<VictimServicesAttendanceModel> VictimServicesAttendanceModel { get; set; }
    }
}
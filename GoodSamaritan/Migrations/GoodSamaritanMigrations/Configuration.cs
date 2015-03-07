namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GoodSamaritan.Models;
    using GoodSamaritan.Models.ClientEntity;
    using GoodSamaritan.Models.SmartEntity;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodSamaritan.Models.GoodSamaritanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"Migrations\GoodSamaritanMigrations";
        }

        protected override void Seed(GoodSamaritan.Models.GoodSamaritanContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            // Smart Entity
            context.SexWorkerExploitationModel.AddOrUpdate(
                  s => s.SexWorkerExploitation,
                  new SexWorkerExploitationModel { SexWorkerExploitation = "Yes" },
                  new SexWorkerExploitationModel { SexWorkerExploitation = "No" },
                  new SexWorkerExploitationModel { SexWorkerExploitation = "N/A" }
            );

            context.MultiplePerpetratorsModel.AddOrUpdate(
                  s => s.MultiplePerpetrators,
                  new MultiplePerpetratorsModel { MultiplePerpetrators = "Yes" },
                  new MultiplePerpetratorsModel { MultiplePerpetrators = "No" },
                  new MultiplePerpetratorsModel { MultiplePerpetrators = "N/A" }
            );

            context.DrugFacilitatedAssaultModel.AddOrUpdate(
                  s => s.DrugFacilitatedAssault,
                  new DrugFacilitatedAssaultModel { DrugFacilitatedAssault = "Yes" },
                  new DrugFacilitatedAssaultModel { DrugFacilitatedAssault = "No" },
                  new DrugFacilitatedAssaultModel { DrugFacilitatedAssault = "N/A" }
            );

            context.CityOfAssaultModel.AddOrUpdate(
                  s => s.CityOfAssault,
                  new CityOfAssaultModel { CityOfAssault = "Surrey" },
                  new CityOfAssaultModel { CityOfAssault = "Abbotsford" },
                  new CityOfAssaultModel { CityOfAssault = "Agassiz" },
                  new CityOfAssaultModel { CityOfAssault = "Boston Bar" },
                  new CityOfAssaultModel { CityOfAssault = "Burnaby" },
                  new CityOfAssaultModel { CityOfAssault = "Chilliwack" },
                  new CityOfAssaultModel { CityOfAssault = "Coquitlam" },
                  new CityOfAssaultModel { CityOfAssault = "Delta" },
                  new CityOfAssaultModel { CityOfAssault = "Harrison Hot Springs" },
                  new CityOfAssaultModel { CityOfAssault = "Hope" },
                  new CityOfAssaultModel { CityOfAssault = "Langley" },
                  new CityOfAssaultModel { CityOfAssault = "Maple Ridge" },
                  new CityOfAssaultModel { CityOfAssault = "Mission" },
                  new CityOfAssaultModel { CityOfAssault = "New Westminster" },
                  new CityOfAssaultModel { CityOfAssault = "Pitt Meadows" },
                  new CityOfAssaultModel { CityOfAssault = "Port Coquitlam" },
                  new CityOfAssaultModel { CityOfAssault = "Port Moody" },
                  new CityOfAssaultModel { CityOfAssault = "Vancouver" },
                  new CityOfAssaultModel { CityOfAssault = "White Rock" },
                  new CityOfAssaultModel { CityOfAssault = "Yale" },
                  new CityOfAssaultModel { CityOfAssault = "Other - BC" },
                  new CityOfAssaultModel { CityOfAssault = "Outside-of-Province" },
                  new CityOfAssaultModel { CityOfAssault = "International" }
            );

            context.CityOfResidenceModel.AddOrUpdate(
                  s => s.CityOfResidence,
                  new CityOfResidenceModel { CityOfResidence = "Surrey" },
                  new CityOfResidenceModel { CityOfResidence = "Abbotsford" },
                  new CityOfResidenceModel { CityOfResidence = "Agassiz" },
                  new CityOfResidenceModel { CityOfResidence = "Boston Bar" },
                  new CityOfResidenceModel { CityOfResidence = "Burnaby" },
                  new CityOfResidenceModel { CityOfResidence = "Chilliwack" },
                  new CityOfResidenceModel { CityOfResidence = "Coquitlam" },
                  new CityOfResidenceModel { CityOfResidence = "Delta" },
                  new CityOfResidenceModel { CityOfResidence = "Harrison Hot Springs" },
                  new CityOfResidenceModel { CityOfResidence = "Hope" },
                  new CityOfResidenceModel { CityOfResidence = "Langley" },
                  new CityOfResidenceModel { CityOfResidence = "Maple Ridge" },
                  new CityOfResidenceModel { CityOfResidence = "Mission" },
                  new CityOfResidenceModel { CityOfResidence = "New Westminster" },
                  new CityOfResidenceModel { CityOfResidence = "Pitt Meadows" },
                  new CityOfResidenceModel { CityOfResidence = "Port Coquitlam" },
                  new CityOfResidenceModel { CityOfResidence = "Port Moody" },
                  new CityOfResidenceModel { CityOfResidence = "Vancouver" },
                  new CityOfResidenceModel { CityOfResidence = "White Rock" },
                  new CityOfResidenceModel { CityOfResidence = "Yale" },
                  new CityOfResidenceModel { CityOfResidence = "Other - BC" },
                  new CityOfResidenceModel { CityOfResidence = "Outside-of-Province" },
                  new CityOfResidenceModel { CityOfResidence = "International" }
            );

            context.ReferringHospitalModel.AddOrUpdate(
                  s => s.ReferringHospital,
                  new ReferringHospitalModel { ReferringHospital = "Abbotsford Regional Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Surrey Memorial Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Burnaby Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Chilliwack General Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Delta Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Eagle Ridge Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Fraser Canyon Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Langley Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Mission Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Peace Arch Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Ridge Medows Hospital" },
                  new ReferringHospitalModel { ReferringHospital = "Royal Columbia Hospital" }
            );

            context.HospitalAttendedModel.AddOrUpdate(
                  s => s.HospitalAttended,
                  new HospitalAttendedModel { HospitalAttended = "Abbotsford Regional Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Surrey Memorial Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Burnaby Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Chilliwack General Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Delta Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Eagle Ridge Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Fraser Canyon Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Langley Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Mission Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Peace Arch Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Ridge Medows Hospital" },
                  new HospitalAttendedModel { HospitalAttended = "Royal Columbia Hospital" }
            );

            context.SocialWorkAttendanceModel.AddOrUpdate(
                  s => s.SocialWorkAttendance,
                  new SocialWorkAttendanceModel { SocialWorkAttendance = "Yes" },
                  new SocialWorkAttendanceModel { SocialWorkAttendance = "No" },
                  new SocialWorkAttendanceModel { SocialWorkAttendance = "N/A" }
            );

            context.PoliceAttendanceModel.AddOrUpdate(
                  s => s.PoliceAttendance,
                  new PoliceAttendanceModel { PoliceAttendance = "Yes" },
                  new PoliceAttendanceModel { PoliceAttendance = "No" },
                  new PoliceAttendanceModel { PoliceAttendance = "N/A" }
            );

            context.VictimServicesAttendanceModel.AddOrUpdate(
                  s => s.VictimServicesAttendance,
                  new VictimServicesAttendanceModel { VictimServicesAttendance = "Yes" },
                  new VictimServicesAttendanceModel { VictimServicesAttendance = "No" },
                  new VictimServicesAttendanceModel { VictimServicesAttendance = "N/A" }
            );

            context.MedicalOnlyModel.AddOrUpdate(
                  s => s.MedicalOnly,
                  new MedicalOnlyModel { MedicalOnly = "Yes" },
                  new MedicalOnlyModel { MedicalOnly = "No" },
                  new MedicalOnlyModel { MedicalOnly = "N/A" }
            );

            context.EvidenceStoredModel.AddOrUpdate(
                  s => s.EvidenceStored,
                  new EvidenceStoredModel { EvidenceStored = "Yes" },
                  new EvidenceStoredModel { EvidenceStored = "No" },
                  new EvidenceStoredModel { EvidenceStored = "N/A" }
            );

            context.HIVMedsModel.AddOrUpdate(
                  s => s.HIVMeds,
                  new HIVMedsModel { HIVMeds = "Yes" },
                  new HIVMedsModel { HIVMeds = "No" },
                  new HIVMedsModel { HIVMeds = "N/A" }
            );

            context.ReferredToCBVSModel.AddOrUpdate(
                  s => s.ReferredToCBVS,
                  new ReferredToCBVSModel { ReferredToCBVS = "Yes" },
                  new ReferredToCBVSModel { ReferredToCBVS = "No" },
                  new ReferredToCBVSModel { ReferredToCBVS = "PVBS Only" },
                  new ReferredToCBVSModel { ReferredToCBVS = "N/A" }
            );

            context.PoliceReportedModel.AddOrUpdate(
                  s => s.PoliceReported,
                  new PoliceReportedModel { PoliceReported = "Yes" },
                  new PoliceReportedModel { PoliceReported = "No" },
                  new PoliceReportedModel { PoliceReported = "N/A" }
            );

            context.ThirdPartyReportModel.AddOrUpdate(
                  s => s.ThirdPartyReport,
                  new ThirdPartyReportModel { ThirdPartyReport = "Yes" },
                  new ThirdPartyReportModel { ThirdPartyReport = "No" },
                  new ThirdPartyReportModel { ThirdPartyReport = "N/A" }
            );

            context.BadDateReportModel.AddOrUpdate(
                  s => s.BadDateReport,
                  new BadDateReportModel { BadDateReport = "Yes" },
                  new BadDateReportModel { BadDateReport = "No" },
                  new BadDateReportModel { BadDateReport = "N/A" }
            );

            context.FiscalYearModel.AddOrUpdate(
                s => s.FiscalYear,
                new FiscalYearModel { FiscalYear = "10-11" },
                new FiscalYearModel { FiscalYear = "11-12" },
                new FiscalYearModel { FiscalYear = "12-13" },
                new FiscalYearModel { FiscalYear = "13-14" },
                new FiscalYearModel { FiscalYear = "14-15" },
                new FiscalYearModel { FiscalYear = "15-16" },
                new FiscalYearModel { FiscalYear = "16-17" }
            );

            context.RiskLevelModel.AddOrUpdate(
                s => s.RiskLevel,
                new RiskLevelModel { RiskLevel = "High" },
                new RiskLevelModel { RiskLevel = "DVU" },
                new RiskLevelModel { RiskLevel = "null" }
            );

            context.CrisisModel.AddOrUpdate(
                s => s.Crisis,
                new CrisisModel { Crisis = "Call" },
                new CrisisModel { Crisis = "Accompaniment" },
                new CrisisModel { Crisis = "Drop-In" }
            );

            context.ServiceModel.AddOrUpdate(
                s => s.Service,
                new ServiceModel { Service = "File" },
                new ServiceModel { Service = "N/A" }
            );

            context.ProgramModel.AddOrUpdate(
                s => s.Program,
                new ProgramModel { Program = "Crisis" },
                new ProgramModel { Program = "Court" },
                new ProgramModel { Program = "SMART" },
                new ProgramModel { Program = "DVU" },
                new ProgramModel { Program = "MCFD" }
            );

            context.RiskStatusModel.AddOrUpdate(
                s => s.RiskStatus,
                new RiskStatusModel { RiskStatus = "Pending" },
                new RiskStatusModel { RiskStatus = "Complete" },
                new RiskStatusModel { RiskStatus = "null" }
            );

            context.AssignedWorkerModel.AddOrUpdate(
                s => s.AssignedWorker,
                new AssignedWorkerModel { AssignedWorker = "Michelle" },
                new AssignedWorkerModel { AssignedWorker = "Tyra" },
                new AssignedWorkerModel { AssignedWorker = "Louise" },
                new AssignedWorkerModel { AssignedWorker = "Angela" },
                new AssignedWorkerModel { AssignedWorker = "Dave" },
                new AssignedWorkerModel { AssignedWorker = "Troy" },
                new AssignedWorkerModel { AssignedWorker = "Michael" },
                new AssignedWorkerModel { AssignedWorker = "Manpreet" },
                new AssignedWorkerModel { AssignedWorker = "Patrick" },
                new AssignedWorkerModel { AssignedWorker = "None" }
            );

            context.ReferralSourceMode.AddOrUpdate(
                s => s.ReferralSource,
                new ReferralSourceModel { ReferralSource = "Community Agency" },
                new ReferralSourceModel { ReferralSource = "Family/Friend" },
                new ReferralSourceModel { ReferralSource = "Government" },
                new ReferralSourceModel { ReferralSource = "CVAP" },
                new ReferralSourceModel { ReferralSource = "CBVS" }
            );

            context.ReferralContactModel.AddOrUpdate(
                s => s.ReferralContact,
                new ReferralContactModel { ReferralContact = "PBVS" },
                new ReferralContactModel { ReferralContact = "MCFD" },
                new ReferralContactModel { ReferralContact = "VictimLINK" },
                new ReferralContactModel { ReferralContact = "TH" },
                new ReferralContactModel { ReferralContact = "Self" },
                new ReferralContactModel { ReferralContact = "FNS" },
                new ReferralContactModel { ReferralContact = "Other" },
                new ReferralContactModel { ReferralContact = "Medical" }
            );

            context.IncidentModel.AddOrUpdate(
                s => s.Incident,
                new IncidentModel { Incident = "Abduction" },
                new IncidentModel { Incident = "Adult Historical Sexual Assault" },
                new IncidentModel { Incident = "Adult Sexual Assault" },
                new IncidentModel { Incident = "Partner Assault" },
                new IncidentModel { Incident = "Attempted Murder" },
                new IncidentModel { Incident = "Child Physical Assault" },
                new IncidentModel { Incident = "Child Sexual Abuse/Exploitation" },
                new IncidentModel { Incident = "Criminal Harassment/Stalking" },
                new IncidentModel { Incident = "Elder Abuse" },
                new IncidentModel { Incident = "Human Trafficking" },
                new IncidentModel { Incident = "Murder" },
                new IncidentModel { Incident = "N/A" },
                new IncidentModel { Incident = "Other" },
                new IncidentModel { Incident = "Other Assault" },
                new IncidentModel { Incident = "Other Crime - DV" },
                new IncidentModel { Incident = "Other Familial Assault" },
                new IncidentModel { Incident = "Threatening" },
                new IncidentModel { Incident = "Youth Sexual Assault/Exploitation" }
            );

            context.AbuserRelationshipModel.AddOrUpdate(
                s => s.AbuserRelationship,
                new AbuserRelationshipModel { AbuserRelationship = "Acquaintance" },
                new AbuserRelationshipModel { AbuserRelationship = "Bad Date" },
                new AbuserRelationshipModel { AbuserRelationship = "DNA" },
                new AbuserRelationshipModel { AbuserRelationship = "Ex-Partner" },
                new AbuserRelationshipModel { AbuserRelationship = "Friend" },
                new AbuserRelationshipModel { AbuserRelationship = "Multiple Perps" },
                new AbuserRelationshipModel { AbuserRelationship = "N/A" },
                new AbuserRelationshipModel { AbuserRelationship = "Other Familal" },
                new AbuserRelationshipModel { AbuserRelationship = "Parent" },
                new AbuserRelationshipModel { AbuserRelationship = "Partner" },
                new AbuserRelationshipModel { AbuserRelationship = "Sibling" },
                new AbuserRelationshipModel { AbuserRelationship = "Stranger" }
            );

            context.VictimOfIncidentModel.AddOrUpdate(
                s => s.VictimOfIncident,
                new VictimOfIncidentModel { VictimOfIncident = "Primary" },
                new VictimOfIncidentModel { VictimOfIncident = "Secondary" }
            );

            context.FamilyViolenceFileModel.AddOrUpdate(
                s => s.FamilyViolenceFile,
                new FamilyViolenceFileModel { FamilyViolenceFile = "Yes" },
                new FamilyViolenceFileModel { FamilyViolenceFile = "No" },
                new FamilyViolenceFileModel { FamilyViolenceFile = "N/A" }
            );

            context.EthnicityModel.AddOrUpdate(
                s => s.Ethnicity,
                new EthnicityModel { Ethnicity = "Indigenous" },
                new EthnicityModel { Ethnicity = "Asian" },
                new EthnicityModel { Ethnicity = "Black" },
                new EthnicityModel { Ethnicity = "Caucasian" },
                new EthnicityModel { Ethnicity = "Declined" },
                new EthnicityModel { Ethnicity = "Latin" },
                new EthnicityModel { Ethnicity = "Middle Eastern" },
                new EthnicityModel { Ethnicity = "Other" },
                new EthnicityModel { Ethnicity = "South Asian" },
                new EthnicityModel { Ethnicity = "South East Asian" }
            );

            context.AgeModel.AddOrUpdate(
                s => s.Age,
                new AgeModel { Age = "Adult <24 <65" },
                new AgeModel { Age = "Youth >12 <19" },
                new AgeModel { Age = "Youth >18 <25" },
                new AgeModel { Age = "Child <13" },
                new AgeModel { Age = "Senior >64" }
            );

            context.RepeatClientModel.AddOrUpdate(
                s => s.RepeatClient,
                new RepeatClientModel { RepeatClient = "Yes" },
                new RepeatClientModel { RepeatClient = "null" }
            );

            context.DuplicateFileModel.AddOrUpdate(
                s => s.DuplicateFile,
                new DuplicateFileModel { DuplicateFile = "Yes" },
                new DuplicateFileModel { DuplicateFile = "null" }
            );

            context.StatusOfFileModel.AddOrUpdate(
                s => s.StatusOfFile,
                new StatusOfFileModel { StatusOfFile = "Reopened" },
                new StatusOfFileModel { StatusOfFile = "Closed" },
                new StatusOfFileModel { StatusOfFile = "Open" }
             );
        }
    }
}

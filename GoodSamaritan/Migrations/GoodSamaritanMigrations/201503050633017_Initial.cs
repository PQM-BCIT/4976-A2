namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationshipModels",
                c => new
                    {
                        AbuserRelationshipId = c.Int(nullable: false, identity: true),
                        AbuserRelationship = c.String(),
                    })
                .PrimaryKey(t => t.AbuserRelationshipId);
            
            CreateTable(
                "dbo.ClientModels",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNumber = c.String(),
                        CourtFileNumber = c.Int(nullable: false),
                        RiskAssessmentAssignedTo = c.String(),
                        AbuserSurnameFirstName = c.String(),
                        NumberOfChildren0To6 = c.Int(nullable: false),
                        NumberOfChildren7To12 = c.Int(nullable: false),
                        NumberOfChildren13To18 = c.Int(nullable: false),
                        DateLastTransferred = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReOpened = c.DateTime(nullable: false),
                        AbuserRealtionship_AbuserRelationshipId = c.Int(),
                        Age_AgeId = c.Int(),
                        AssignedWorker_AssignedWorkerId = c.Int(),
                        Crisis_CrisisId = c.Int(),
                        DuplicateFile_DuplicateFileId = c.Int(),
                        Ethnicity_EthnicityId = c.Int(),
                        FamilyViolenceFile_FamilyViolenceFileId = c.Int(),
                        FiscalYear_FiscalYearId = c.Int(),
                        Incident_IncidentId = c.Int(),
                        Program_ProgramId = c.Int(),
                        ReferralSource_ReferralSourceId = c.Int(),
                        RepeatClient_RepeatClientId = c.Int(),
                        RiskLevel_RiskLevelId = c.Int(),
                        RiskStatus_RiskStatusId = c.Int(),
                        Service_ServiceId = c.Int(),
                        StatusOfFile_StatusOfFileId = c.Int(),
                        VictimOfIncident_VictimOfIncidentId = c.Int(),
                        ReferralContactModel_ReferralContactId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.AbuserRelationshipModels", t => t.AbuserRealtionship_AbuserRelationshipId)
                .ForeignKey("dbo.AgeModels", t => t.Age_AgeId)
                .ForeignKey("dbo.AssignedWorkerModels", t => t.AssignedWorker_AssignedWorkerId)
                .ForeignKey("dbo.CrisisModels", t => t.Crisis_CrisisId)
                .ForeignKey("dbo.DuplicateFileModels", t => t.DuplicateFile_DuplicateFileId)
                .ForeignKey("dbo.EthnicityModels", t => t.Ethnicity_EthnicityId)
                .ForeignKey("dbo.FamilyViolenceFileModels", t => t.FamilyViolenceFile_FamilyViolenceFileId)
                .ForeignKey("dbo.FiscalYearModels", t => t.FiscalYear_FiscalYearId)
                .ForeignKey("dbo.IncidentModels", t => t.Incident_IncidentId)
                .ForeignKey("dbo.ProgramModels", t => t.Program_ProgramId)
                .ForeignKey("dbo.ReferralSourceModels", t => t.ReferralSource_ReferralSourceId)
                .ForeignKey("dbo.RepeatClientModels", t => t.RepeatClient_RepeatClientId)
                .ForeignKey("dbo.RiskLevelModels", t => t.RiskLevel_RiskLevelId)
                .ForeignKey("dbo.RiskStatusModels", t => t.RiskStatus_RiskStatusId)
                .ForeignKey("dbo.ServiceModels", t => t.Service_ServiceId)
                .ForeignKey("dbo.StatusOfFileModels", t => t.StatusOfFile_StatusOfFileId)
                .ForeignKey("dbo.VictimOfIncidentModels", t => t.VictimOfIncident_VictimOfIncidentId)
                .ForeignKey("dbo.ReferralContactModels", t => t.ReferralContactModel_ReferralContactId)
                .Index(t => t.AbuserRealtionship_AbuserRelationshipId)
                .Index(t => t.Age_AgeId)
                .Index(t => t.AssignedWorker_AssignedWorkerId)
                .Index(t => t.Crisis_CrisisId)
                .Index(t => t.DuplicateFile_DuplicateFileId)
                .Index(t => t.Ethnicity_EthnicityId)
                .Index(t => t.FamilyViolenceFile_FamilyViolenceFileId)
                .Index(t => t.FiscalYear_FiscalYearId)
                .Index(t => t.Incident_IncidentId)
                .Index(t => t.Program_ProgramId)
                .Index(t => t.ReferralSource_ReferralSourceId)
                .Index(t => t.RepeatClient_RepeatClientId)
                .Index(t => t.RiskLevel_RiskLevelId)
                .Index(t => t.RiskStatus_RiskStatusId)
                .Index(t => t.Service_ServiceId)
                .Index(t => t.StatusOfFile_StatusOfFileId)
                .Index(t => t.VictimOfIncident_VictimOfIncidentId)
                .Index(t => t.ReferralContactModel_ReferralContactId);
            
            CreateTable(
                "dbo.AgeModels",
                c => new
                    {
                        AgeId = c.Int(nullable: false, identity: true),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.AgeId);
            
            CreateTable(
                "dbo.AssignedWorkerModels",
                c => new
                    {
                        AssignedWorkerId = c.Int(nullable: false, identity: true),
                        AssignedWorker = c.String(),
                    })
                .PrimaryKey(t => t.AssignedWorkerId);
            
            CreateTable(
                "dbo.CrisisModels",
                c => new
                    {
                        CrisisId = c.Int(nullable: false, identity: true),
                        Crisis = c.String(),
                    })
                .PrimaryKey(t => t.CrisisId);
            
            CreateTable(
                "dbo.DuplicateFileModels",
                c => new
                    {
                        DuplicateFileId = c.Int(nullable: false, identity: true),
                        DuplicateFile = c.String(),
                    })
                .PrimaryKey(t => t.DuplicateFileId);
            
            CreateTable(
                "dbo.EthnicityModels",
                c => new
                    {
                        EthnicityId = c.Int(nullable: false, identity: true),
                        Ethnicity = c.String(),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.FamilyViolenceFileModels",
                c => new
                    {
                        FamilyViolenceFileId = c.Int(nullable: false, identity: true),
                        FamilyViolenceFile = c.String(),
                    })
                .PrimaryKey(t => t.FamilyViolenceFileId);
            
            CreateTable(
                "dbo.FiscalYearModels",
                c => new
                    {
                        FiscalYearId = c.Int(nullable: false, identity: true),
                        FiscalYear = c.String(),
                    })
                .PrimaryKey(t => t.FiscalYearId);
            
            CreateTable(
                "dbo.IncidentModels",
                c => new
                    {
                        IncidentId = c.Int(nullable: false, identity: true),
                        Incident = c.String(),
                    })
                .PrimaryKey(t => t.IncidentId);
            
            CreateTable(
                "dbo.ProgramModels",
                c => new
                    {
                        ProgramId = c.Int(nullable: false, identity: true),
                        Program = c.String(),
                    })
                .PrimaryKey(t => t.ProgramId);
            
            CreateTable(
                "dbo.ReferralSourceModels",
                c => new
                    {
                        ReferralSourceId = c.Int(nullable: false, identity: true),
                        ReferralSource = c.String(),
                    })
                .PrimaryKey(t => t.ReferralSourceId);
            
            CreateTable(
                "dbo.RepeatClientModels",
                c => new
                    {
                        RepeatClientId = c.Int(nullable: false, identity: true),
                        RepeatClient = c.String(),
                    })
                .PrimaryKey(t => t.RepeatClientId);
            
            CreateTable(
                "dbo.RiskLevelModels",
                c => new
                    {
                        RiskLevelId = c.Int(nullable: false, identity: true),
                        RiskLevel = c.String(),
                    })
                .PrimaryKey(t => t.RiskLevelId);
            
            CreateTable(
                "dbo.RiskStatusModels",
                c => new
                    {
                        RiskStatusId = c.Int(nullable: false, identity: true),
                        RiskStatus = c.String(),
                    })
                .PrimaryKey(t => t.RiskStatusId);
            
            CreateTable(
                "dbo.ServiceModels",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Service = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.StatusOfFileModels",
                c => new
                    {
                        StatusOfFileId = c.Int(nullable: false, identity: true),
                        StatusOfFile = c.String(),
                    })
                .PrimaryKey(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.VictimOfIncidentModels",
                c => new
                    {
                        VictimOfIncidentId = c.Int(nullable: false, identity: true),
                        VictimOfIncident = c.String(),
                    })
                .PrimaryKey(t => t.VictimOfIncidentId);
            
            CreateTable(
                "dbo.BadDateReportModels",
                c => new
                    {
                        BadDateReportId = c.Int(nullable: false, identity: true),
                        BadDateReport = c.String(),
                    })
                .PrimaryKey(t => t.BadDateReportId);
            
            CreateTable(
                "dbo.SmartModels",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        AccompanimentMinute = c.Int(nullable: false),
                        NumberTransportsProvided = c.Int(nullable: false),
                        ReferredToNursePractitioner = c.Boolean(nullable: false),
                        BadDateReport_BadDateReportId = c.Int(),
                        CityOfAssault_CityOfAssaultId = c.Int(),
                        CityOfResidence_CityOfResidenceId = c.Int(),
                        DrugFacilitatedAssault_DrugFacilitatedAssaultId = c.Int(),
                        EvidenceStored_EvidenceStoredId = c.Int(),
                        HIVMeds_HIVMedsId = c.Int(),
                        HospitalAttended_HospitalAttendedId = c.Int(),
                        MedicalOnly_MedicalOnlyId = c.Int(),
                        MultiplePerpetrators_MultiplePerpetratorsId = c.Int(),
                        PoliceAttendance_PoliceAttendanceId = c.Int(),
                        PoliceReported_PoliceReportedId = c.Int(),
                        ReferredToCBVS_ReferredToCBVSId = c.Int(),
                        ReferringHospital_ReferringHospitalId = c.Int(),
                        SexWorkerExploitation_SexWorkerExploitationId = c.Int(),
                        SocialWorkAttendance_SocialWorkAttendanceId = c.Int(),
                        ThirdPartyReport_ThirdPartyReportId = c.Int(),
                        VictimServicesAttendance_VictimServicesAttendanceId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.BadDateReportModels", t => t.BadDateReport_BadDateReportId)
                .ForeignKey("dbo.CityOfAssaultModels", t => t.CityOfAssault_CityOfAssaultId)
                .ForeignKey("dbo.CityOfResidenceModels", t => t.CityOfResidence_CityOfResidenceId)
                .ForeignKey("dbo.DrugFacilitatedAssaultModels", t => t.DrugFacilitatedAssault_DrugFacilitatedAssaultId)
                .ForeignKey("dbo.EvidenceStoredModels", t => t.EvidenceStored_EvidenceStoredId)
                .ForeignKey("dbo.HIVMedsModels", t => t.HIVMeds_HIVMedsId)
                .ForeignKey("dbo.HospitalAttendedModels", t => t.HospitalAttended_HospitalAttendedId)
                .ForeignKey("dbo.MedicalOnlyModels", t => t.MedicalOnly_MedicalOnlyId)
                .ForeignKey("dbo.MultiplePerpetratorsModels", t => t.MultiplePerpetrators_MultiplePerpetratorsId)
                .ForeignKey("dbo.PoliceAttendanceModels", t => t.PoliceAttendance_PoliceAttendanceId)
                .ForeignKey("dbo.PoliceReportedModels", t => t.PoliceReported_PoliceReportedId)
                .ForeignKey("dbo.ReferredToCBVSModels", t => t.ReferredToCBVS_ReferredToCBVSId)
                .ForeignKey("dbo.ReferringHospitalModels", t => t.ReferringHospital_ReferringHospitalId)
                .ForeignKey("dbo.SexWorkerExploitationModels", t => t.SexWorkerExploitation_SexWorkerExploitationId)
                .ForeignKey("dbo.SocialWorkAttendanceModels", t => t.SocialWorkAttendance_SocialWorkAttendanceId)
                .ForeignKey("dbo.ThirdPartyReportModels", t => t.ThirdPartyReport_ThirdPartyReportId)
                .ForeignKey("dbo.VictimServicesAttendanceModels", t => t.VictimServicesAttendance_VictimServicesAttendanceId)
                .Index(t => t.BadDateReport_BadDateReportId)
                .Index(t => t.CityOfAssault_CityOfAssaultId)
                .Index(t => t.CityOfResidence_CityOfResidenceId)
                .Index(t => t.DrugFacilitatedAssault_DrugFacilitatedAssaultId)
                .Index(t => t.EvidenceStored_EvidenceStoredId)
                .Index(t => t.HIVMeds_HIVMedsId)
                .Index(t => t.HospitalAttended_HospitalAttendedId)
                .Index(t => t.MedicalOnly_MedicalOnlyId)
                .Index(t => t.MultiplePerpetrators_MultiplePerpetratorsId)
                .Index(t => t.PoliceAttendance_PoliceAttendanceId)
                .Index(t => t.PoliceReported_PoliceReportedId)
                .Index(t => t.ReferredToCBVS_ReferredToCBVSId)
                .Index(t => t.ReferringHospital_ReferringHospitalId)
                .Index(t => t.SexWorkerExploitation_SexWorkerExploitationId)
                .Index(t => t.SocialWorkAttendance_SocialWorkAttendanceId)
                .Index(t => t.ThirdPartyReport_ThirdPartyReportId)
                .Index(t => t.VictimServicesAttendance_VictimServicesAttendanceId);
            
            CreateTable(
                "dbo.CityOfAssaultModels",
                c => new
                    {
                        CityOfAssaultId = c.Int(nullable: false, identity: true),
                        CityOfAssault = c.String(),
                    })
                .PrimaryKey(t => t.CityOfAssaultId);
            
            CreateTable(
                "dbo.CityOfResidenceModels",
                c => new
                    {
                        CityOfResidenceId = c.Int(nullable: false, identity: true),
                        CityOfResidence = c.String(),
                    })
                .PrimaryKey(t => t.CityOfResidenceId);
            
            CreateTable(
                "dbo.DrugFacilitatedAssaultModels",
                c => new
                    {
                        DrugFacilitatedAssaultId = c.Int(nullable: false, identity: true),
                        DrugFacilitatedAssault = c.String(),
                    })
                .PrimaryKey(t => t.DrugFacilitatedAssaultId);
            
            CreateTable(
                "dbo.EvidenceStoredModels",
                c => new
                    {
                        EvidenceStoredId = c.Int(nullable: false, identity: true),
                        EvidenceStored = c.String(),
                    })
                .PrimaryKey(t => t.EvidenceStoredId);
            
            CreateTable(
                "dbo.HIVMedsModels",
                c => new
                    {
                        HIVMedsId = c.Int(nullable: false, identity: true),
                        HIVMeds = c.String(),
                    })
                .PrimaryKey(t => t.HIVMedsId);
            
            CreateTable(
                "dbo.HospitalAttendedModels",
                c => new
                    {
                        HospitalAttendedId = c.Int(nullable: false, identity: true),
                        HospitalAttended = c.String(),
                    })
                .PrimaryKey(t => t.HospitalAttendedId);
            
            CreateTable(
                "dbo.MedicalOnlyModels",
                c => new
                    {
                        MedicalOnlyId = c.Int(nullable: false, identity: true),
                        MedicalOnly = c.String(),
                    })
                .PrimaryKey(t => t.MedicalOnlyId);
            
            CreateTable(
                "dbo.MultiplePerpetratorsModels",
                c => new
                    {
                        MultiplePerpetratorsId = c.Int(nullable: false, identity: true),
                        MultiplePerpetrators = c.String(),
                    })
                .PrimaryKey(t => t.MultiplePerpetratorsId);
            
            CreateTable(
                "dbo.PoliceAttendanceModels",
                c => new
                    {
                        PoliceAttendanceId = c.Int(nullable: false, identity: true),
                        PoliceAttendance = c.String(),
                    })
                .PrimaryKey(t => t.PoliceAttendanceId);
            
            CreateTable(
                "dbo.PoliceReportedModels",
                c => new
                    {
                        PoliceReportedId = c.Int(nullable: false, identity: true),
                        PoliceReported = c.String(),
                    })
                .PrimaryKey(t => t.PoliceReportedId);
            
            CreateTable(
                "dbo.ReferredToCBVSModels",
                c => new
                    {
                        ReferredToCBVSId = c.Int(nullable: false, identity: true),
                        ReferredToCBVS = c.String(),
                    })
                .PrimaryKey(t => t.ReferredToCBVSId);
            
            CreateTable(
                "dbo.ReferringHospitalModels",
                c => new
                    {
                        ReferringHospitalId = c.Int(nullable: false, identity: true),
                        ReferringHospital = c.String(),
                    })
                .PrimaryKey(t => t.ReferringHospitalId);
            
            CreateTable(
                "dbo.SexWorkerExploitationModels",
                c => new
                    {
                        SexWorkerExploitationId = c.Int(nullable: false, identity: true),
                        SexWorkerExploitation = c.String(),
                    })
                .PrimaryKey(t => t.SexWorkerExploitationId);
            
            CreateTable(
                "dbo.SocialWorkAttendanceModels",
                c => new
                    {
                        SocialWorkAttendanceId = c.Int(nullable: false, identity: true),
                        SocialWorkAttendance = c.String(),
                    })
                .PrimaryKey(t => t.SocialWorkAttendanceId);
            
            CreateTable(
                "dbo.ThirdPartyReportModels",
                c => new
                    {
                        ThirdPartyReportId = c.Int(nullable: false, identity: true),
                        ThirdPartyReport = c.String(),
                    })
                .PrimaryKey(t => t.ThirdPartyReportId);
            
            CreateTable(
                "dbo.VictimServicesAttendanceModels",
                c => new
                    {
                        VictimServicesAttendanceId = c.Int(nullable: false, identity: true),
                        VictimServicesAttendance = c.String(),
                    })
                .PrimaryKey(t => t.VictimServicesAttendanceId);
            
            CreateTable(
                "dbo.ReferralContactModels",
                c => new
                    {
                        ReferralContactId = c.Int(nullable: false, identity: true),
                        ReferralContact = c.String(),
                    })
                .PrimaryKey(t => t.ReferralContactId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientModels", "ReferralContactModel_ReferralContactId", "dbo.ReferralContactModels");
            DropForeignKey("dbo.SmartModels", "VictimServicesAttendance_VictimServicesAttendanceId", "dbo.VictimServicesAttendanceModels");
            DropForeignKey("dbo.SmartModels", "ThirdPartyReport_ThirdPartyReportId", "dbo.ThirdPartyReportModels");
            DropForeignKey("dbo.SmartModels", "SocialWorkAttendance_SocialWorkAttendanceId", "dbo.SocialWorkAttendanceModels");
            DropForeignKey("dbo.SmartModels", "SexWorkerExploitation_SexWorkerExploitationId", "dbo.SexWorkerExploitationModels");
            DropForeignKey("dbo.SmartModels", "ReferringHospital_ReferringHospitalId", "dbo.ReferringHospitalModels");
            DropForeignKey("dbo.SmartModels", "ReferredToCBVS_ReferredToCBVSId", "dbo.ReferredToCBVSModels");
            DropForeignKey("dbo.SmartModels", "PoliceReported_PoliceReportedId", "dbo.PoliceReportedModels");
            DropForeignKey("dbo.SmartModels", "PoliceAttendance_PoliceAttendanceId", "dbo.PoliceAttendanceModels");
            DropForeignKey("dbo.SmartModels", "MultiplePerpetrators_MultiplePerpetratorsId", "dbo.MultiplePerpetratorsModels");
            DropForeignKey("dbo.SmartModels", "MedicalOnly_MedicalOnlyId", "dbo.MedicalOnlyModels");
            DropForeignKey("dbo.SmartModels", "HospitalAttended_HospitalAttendedId", "dbo.HospitalAttendedModels");
            DropForeignKey("dbo.SmartModels", "HIVMeds_HIVMedsId", "dbo.HIVMedsModels");
            DropForeignKey("dbo.SmartModels", "EvidenceStored_EvidenceStoredId", "dbo.EvidenceStoredModels");
            DropForeignKey("dbo.SmartModels", "DrugFacilitatedAssault_DrugFacilitatedAssaultId", "dbo.DrugFacilitatedAssaultModels");
            DropForeignKey("dbo.SmartModels", "CityOfResidence_CityOfResidenceId", "dbo.CityOfResidenceModels");
            DropForeignKey("dbo.SmartModels", "CityOfAssault_CityOfAssaultId", "dbo.CityOfAssaultModels");
            DropForeignKey("dbo.SmartModels", "BadDateReport_BadDateReportId", "dbo.BadDateReportModels");
            DropForeignKey("dbo.ClientModels", "VictimOfIncident_VictimOfIncidentId", "dbo.VictimOfIncidentModels");
            DropForeignKey("dbo.ClientModels", "StatusOfFile_StatusOfFileId", "dbo.StatusOfFileModels");
            DropForeignKey("dbo.ClientModels", "Service_ServiceId", "dbo.ServiceModels");
            DropForeignKey("dbo.ClientModels", "RiskStatus_RiskStatusId", "dbo.RiskStatusModels");
            DropForeignKey("dbo.ClientModels", "RiskLevel_RiskLevelId", "dbo.RiskLevelModels");
            DropForeignKey("dbo.ClientModels", "RepeatClient_RepeatClientId", "dbo.RepeatClientModels");
            DropForeignKey("dbo.ClientModels", "ReferralSource_ReferralSourceId", "dbo.ReferralSourceModels");
            DropForeignKey("dbo.ClientModels", "Program_ProgramId", "dbo.ProgramModels");
            DropForeignKey("dbo.ClientModels", "Incident_IncidentId", "dbo.IncidentModels");
            DropForeignKey("dbo.ClientModels", "FiscalYear_FiscalYearId", "dbo.FiscalYearModels");
            DropForeignKey("dbo.ClientModels", "FamilyViolenceFile_FamilyViolenceFileId", "dbo.FamilyViolenceFileModels");
            DropForeignKey("dbo.ClientModels", "Ethnicity_EthnicityId", "dbo.EthnicityModels");
            DropForeignKey("dbo.ClientModels", "DuplicateFile_DuplicateFileId", "dbo.DuplicateFileModels");
            DropForeignKey("dbo.ClientModels", "Crisis_CrisisId", "dbo.CrisisModels");
            DropForeignKey("dbo.ClientModels", "AssignedWorker_AssignedWorkerId", "dbo.AssignedWorkerModels");
            DropForeignKey("dbo.ClientModels", "Age_AgeId", "dbo.AgeModels");
            DropForeignKey("dbo.ClientModels", "AbuserRealtionship_AbuserRelationshipId", "dbo.AbuserRelationshipModels");
            DropIndex("dbo.SmartModels", new[] { "VictimServicesAttendance_VictimServicesAttendanceId" });
            DropIndex("dbo.SmartModels", new[] { "ThirdPartyReport_ThirdPartyReportId" });
            DropIndex("dbo.SmartModels", new[] { "SocialWorkAttendance_SocialWorkAttendanceId" });
            DropIndex("dbo.SmartModels", new[] { "SexWorkerExploitation_SexWorkerExploitationId" });
            DropIndex("dbo.SmartModels", new[] { "ReferringHospital_ReferringHospitalId" });
            DropIndex("dbo.SmartModels", new[] { "ReferredToCBVS_ReferredToCBVSId" });
            DropIndex("dbo.SmartModels", new[] { "PoliceReported_PoliceReportedId" });
            DropIndex("dbo.SmartModels", new[] { "PoliceAttendance_PoliceAttendanceId" });
            DropIndex("dbo.SmartModels", new[] { "MultiplePerpetrators_MultiplePerpetratorsId" });
            DropIndex("dbo.SmartModels", new[] { "MedicalOnly_MedicalOnlyId" });
            DropIndex("dbo.SmartModels", new[] { "HospitalAttended_HospitalAttendedId" });
            DropIndex("dbo.SmartModels", new[] { "HIVMeds_HIVMedsId" });
            DropIndex("dbo.SmartModels", new[] { "EvidenceStored_EvidenceStoredId" });
            DropIndex("dbo.SmartModels", new[] { "DrugFacilitatedAssault_DrugFacilitatedAssaultId" });
            DropIndex("dbo.SmartModels", new[] { "CityOfResidence_CityOfResidenceId" });
            DropIndex("dbo.SmartModels", new[] { "CityOfAssault_CityOfAssaultId" });
            DropIndex("dbo.SmartModels", new[] { "BadDateReport_BadDateReportId" });
            DropIndex("dbo.ClientModels", new[] { "ReferralContactModel_ReferralContactId" });
            DropIndex("dbo.ClientModels", new[] { "VictimOfIncident_VictimOfIncidentId" });
            DropIndex("dbo.ClientModels", new[] { "StatusOfFile_StatusOfFileId" });
            DropIndex("dbo.ClientModels", new[] { "Service_ServiceId" });
            DropIndex("dbo.ClientModels", new[] { "RiskStatus_RiskStatusId" });
            DropIndex("dbo.ClientModels", new[] { "RiskLevel_RiskLevelId" });
            DropIndex("dbo.ClientModels", new[] { "RepeatClient_RepeatClientId" });
            DropIndex("dbo.ClientModels", new[] { "ReferralSource_ReferralSourceId" });
            DropIndex("dbo.ClientModels", new[] { "Program_ProgramId" });
            DropIndex("dbo.ClientModels", new[] { "Incident_IncidentId" });
            DropIndex("dbo.ClientModels", new[] { "FiscalYear_FiscalYearId" });
            DropIndex("dbo.ClientModels", new[] { "FamilyViolenceFile_FamilyViolenceFileId" });
            DropIndex("dbo.ClientModels", new[] { "Ethnicity_EthnicityId" });
            DropIndex("dbo.ClientModels", new[] { "DuplicateFile_DuplicateFileId" });
            DropIndex("dbo.ClientModels", new[] { "Crisis_CrisisId" });
            DropIndex("dbo.ClientModels", new[] { "AssignedWorker_AssignedWorkerId" });
            DropIndex("dbo.ClientModels", new[] { "Age_AgeId" });
            DropIndex("dbo.ClientModels", new[] { "AbuserRealtionship_AbuserRelationshipId" });
            DropTable("dbo.ReferralContactModels");
            DropTable("dbo.VictimServicesAttendanceModels");
            DropTable("dbo.ThirdPartyReportModels");
            DropTable("dbo.SocialWorkAttendanceModels");
            DropTable("dbo.SexWorkerExploitationModels");
            DropTable("dbo.ReferringHospitalModels");
            DropTable("dbo.ReferredToCBVSModels");
            DropTable("dbo.PoliceReportedModels");
            DropTable("dbo.PoliceAttendanceModels");
            DropTable("dbo.MultiplePerpetratorsModels");
            DropTable("dbo.MedicalOnlyModels");
            DropTable("dbo.HospitalAttendedModels");
            DropTable("dbo.HIVMedsModels");
            DropTable("dbo.EvidenceStoredModels");
            DropTable("dbo.DrugFacilitatedAssaultModels");
            DropTable("dbo.CityOfResidenceModels");
            DropTable("dbo.CityOfAssaultModels");
            DropTable("dbo.SmartModels");
            DropTable("dbo.BadDateReportModels");
            DropTable("dbo.VictimOfIncidentModels");
            DropTable("dbo.StatusOfFileModels");
            DropTable("dbo.ServiceModels");
            DropTable("dbo.RiskStatusModels");
            DropTable("dbo.RiskLevelModels");
            DropTable("dbo.RepeatClientModels");
            DropTable("dbo.ReferralSourceModels");
            DropTable("dbo.ProgramModels");
            DropTable("dbo.IncidentModels");
            DropTable("dbo.FiscalYearModels");
            DropTable("dbo.FamilyViolenceFileModels");
            DropTable("dbo.EthnicityModels");
            DropTable("dbo.DuplicateFileModels");
            DropTable("dbo.CrisisModels");
            DropTable("dbo.AssignedWorkerModels");
            DropTable("dbo.AgeModels");
            DropTable("dbo.ClientModels");
            DropTable("dbo.AbuserRelationshipModels");
        }
    }
}

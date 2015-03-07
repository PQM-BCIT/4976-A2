using GoodSamaritan.Models.ClientEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class ClientModel
    {
        [Key]
        public int ClientReferenceNumber { get; set; }

        [ForeignKey("FiscalYear")]
        public int FiscalYearId { get; set; }
        public FiscalYearModel FiscalYear { get; set; }

        [Range(1, 12, ErrorMessage = "Please enter a valid month (1 - 12)")]
        public int Month { get; set; }

        [Range(1, 31, ErrorMessage = "Please enter a valid date (1-31)")]
        public int Day { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid surname (eg. 'Smith')")]
        public string Surname { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid first name (eg. 'James')")]
        public string FirstName { get; set; }

        [RegularExpression("^([0-9]{2}-[0-9]{5})$", ErrorMessage = "Please use the proper format: 99-99999")]
        public string PoliceFileNumber { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a Court File Number higher than 1")]
        public int CourtFileNumber { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a SWC File Number higher than 1")]
        public int SwcFileNumber { get; set; }

        [ForeignKey("RiskLevel")]
        public int RiskLevelId { get; set; }
        public RiskLevelModel RiskLevel { get; set; }

        [ForeignKey("Crisis")]
        public int CrisisId { get; set; }
        public CrisisModel Crisis { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }

        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public ProgramModel Program { get; set; }

        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Please enter text only assessments")]
        public string RiskAssessmentAssignedTo { get; set; }

        [ForeignKey("RiskStatus")]
        public int RiskStatusId { get; set; }
        public RiskStatusModel RiskStatus { get; set; }

        [ForeignKey("AssignedWorker")]
        public int AssignedWorkerId { get; set; }
        public AssignedWorkerModel AssignedWorker { get; set; }

        [ForeignKey("ReferralSource")]
        public int ReferralSourceId { get; set; }
        public ReferralSourceModel ReferralSource { get; set; }

        [ForeignKey("Incident")]
        public int IncidentId { get; set; }
        public IncidentModel Incident { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid surname (eg. 'Smith')")]
        public string AbuserSurnameName { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid first name (eg. 'James')")]
        public string AbuserFirstName { get; set; }

        [ForeignKey("AbuserRealtionship")]
        public int AbuserRelationshipId { get; set; }
        public AbuserRelationshipModel AbuserRealtionship { get; set; }

        [ForeignKey("VictimOfIncident")]
        public int VictimOfIncidentId { get; set; }
        public VictimOfIncidentModel VictimOfIncident { get; set; }

        [ForeignKey("FamilyViolenceFile")]
        public int FamilyViolenceFileId { get; set; }
        public FamilyViolenceFileModel FamilyViolenceFile { get; set; }

        [RegularExpression("^M|F|Trans$")]
        public char Gender { get; set; }

        [ForeignKey("Ethnicity")]
        public int EthnicityId { get; set; }
        public EthnicityModel Ethnicity { get; set; }

        [ForeignKey("Age")]
        public int AgeId { get; set; }
        public AgeModel Age { get; set; }

        [ForeignKey("RepeatClient")]
        public int RepeatClientId { get; set; }
        public RepeatClientModel RepeatClient { get; set; }

        [ForeignKey("DuplicateFile")]
        public int DuplicateFileId { get; set; }
        public DuplicateFileModel DuplicateFile { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive integer")]
        public int NumberOfChildren0To6 { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive integer")]
        public int NumberOfChildren7To12 { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive integer")]
        public int NumberOfChildren13To18 { get; set; }

        [ForeignKey("StatusOfFile")]
        public int StatusOfFileId { get; set; }
        public StatusOfFileModel StatusOfFile { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastTransferred { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReOpened { get; set; }
    }
}
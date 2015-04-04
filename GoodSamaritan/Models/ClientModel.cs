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

        [Display(Name = "Fiscal Year")]
        public int FiscalYearId { get; set; }
        public FiscalYearModel FiscalYear { get; set; }

        [Range(1, 12, ErrorMessage = "Please enter a valid month (1 - 12)")]
        public int Month { get; set; }

        [Range(1,31, ErrorMessage = "Please enter a valid date (1-31)")]
        public int Day { get; set; }

        [Display(Name = "Surname")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Please enter a valid surname (eg. 'Smith')")]
        public string Surname { get; set; }

        [Display(Name = "First Name")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Please enter a valid first name (eg. 'James')")]
        public string FirstName { get; set; }

        [Display(Name = "Police File Number")]
        [RegularExpression("^([0-9]{2}-[0-9]{5})$", ErrorMessage = "Please use the proper format: 99-99999")]
        public string PoliceFileNumber { get; set; }

        [Display(Name = "Court File Number")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a Court File Number higher than 1")]
        public int CourtFileNumber { get; set; }

        [Display(Name = "SWC File Number")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a SWC File Number higher than 1")]
        public int SwcFileNumber { get; set; }

        [Display(Name = "Risk Level")]
        public int RiskLevelId { get; set; }
        public RiskLevelModel RiskLevel { get; set; }

        [Display(Name = "Crisis")]
        public int CrisisId { get; set; }
        public CrisisModel Crisis { get; set; }

        [Display(Name = "Service")]
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }

        [Display(Name = "Program")]
        public int ProgramId { get; set; }
        public ProgramModel Program { get; set; }

        [Display(Name = "Risk Assessment Assigned to")]
        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Please enter text only assessments")]
        public string RiskAssessmentAssignedTo { get; set; }

        [Display(Name = "Risk Status")]
        public int RiskStatusId { get; set; }
        public RiskStatusModel RiskStatus { get; set; }

        [Display(Name = "Assigned Worker")]
        public int AssignedWorkerId { get; set; }
        public AssignedWorkerModel AssignedWorker { get; set; }

        [Display(Name = "Referral Source")]
        public int ReferralSourceId { get; set; }
        public ReferralSourceModel ReferralSource { get; set; }

        [Display(Name = "Incident")]
        public int IncidentId { get; set; }
        public IncidentModel Incident { get; set; }

        [Display(Name = "Abuser Surname")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Please enter a valid surname (eg. 'Smith')")]
        public string AbuserSurnameName { get; set; }

        [Display(Name = "Abuser First Name")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Please enter a valid first name (eg. 'James')")]
        public string AbuserFirstName { get; set; }

        [Display(Name = "Abuser Relationship")]
        public int AbuserRelationshipId { get; set; }
        public AbuserRelationshipModel AbuserRealtionship { get; set; }

        [Display(Name = "Victim of Incident")]
        public int VictimOfIncidentId { get; set; }
        public VictimOfIncidentModel VictimOfIncident { get; set; }

        [Display(Name = "Family Violence File")]
        public int FamilyViolenceFileId { get; set; }
        public FamilyViolenceFileModel FamilyViolenceFile { get; set; }

        [RegularExpression("^M|F|Trans$")]
        public string Gender { get; set; }

        [Display(Name = "Ethnicity")]
        public int EthnicityId { get; set; }
        public EthnicityModel Ethnicity { get; set; }

        [Display(Name = "Age")]
        public int AgeId { get; set; }
        public AgeModel Age { get; set; }

        [Display(Name = "Repeat Client")]
        public int RepeatClientId { get; set; }
        public RepeatClientModel RepeatClient { get; set; }

        [Display(Name = "Duplicate File")]
        public int DuplicateFileId { get; set; }
        public DuplicateFileModel DuplicateFile { get; set; }

        [Display(Name = "Number of Children (0 to 6 years old)")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive integer")]
        public int NumberOfChildren0To6 { get; set; }

        [Display(Name = "Number of Children (7 - 12 years old)")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive integer")]
        public int NumberOfChildren7To12 { get; set; }

        [Display(Name = "Number of Children (13 - 18 years old)")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive integer")]
        public int NumberOfChildren13To18 { get; set; }

        [Display(Name = "Status of File")]
        public int StatusOfFileId { get; set; }
        public StatusOfFileModel StatusOfFile { get; set; }

        [Display(Name = "Date Last Transferred")]
        [DataType(DataType.Date)]
        public DateTime DateLastTransferred { get; set; }

        [Display(Name = "Date Closed")]
        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }

        [Display(Name = "Date Reopened")]
        [DataType(DataType.Date)]
        public DateTime DateReOpened { get; set; }
    }
}
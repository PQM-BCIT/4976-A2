using GoodSamaritan.Models.ClientEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class ClientModel
    {
        [Key]
        public FiscalYearModel FiscalYear { get; set; }

        [Range(1, 12, ErrorMessage = "Please enter a valid month (1 - 12)")]
        public int Month { get; set; }

        [Range(1,31, ErrorMessage = "Please enter a valid date (1-31)")]
        public int Day { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid surname (eg. 'Smith')")]
        public string Surname { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid first name (eg. 'James')")]
        public string FirstName { get; set; }

        public string PoliceFileNumber { get; set; }
        public int CourtFileNumber { get; set; }
        public RiskLevelModel RiskLevel { get; set; }
        public CrisisModel Crisis { get; set; }
        public ServiceModel Service { get; set; }
        public ProgramModel Program { get; set; }
        public string RiskAssessmentAssignedTo { get; set; }
        public RiskStatus RiskStatus { get; set; }
        public AssignedWorkerModel AssignedWorker { get; set; }
        public ReferralSourceModel ReferralSource { get; set; }
        public IncidentModel Incident { get; set; }
        public string AbuserSurnameFirstName { get; set; }
        public AbuserRealtionshipModel AbuserRealtionship { get; set; }
        public VictimOfIncidentModel VictimOfIncident { get; set; }
        public FamilyViolenceFileModel FamilyViolenceFile { get; set; }
        public char Gender { get; set; }
        public EthnicityModel Ethnicity { get; set; }
        public AgeModel Age { get; set; }
        public RepeatClientModel RepeatClient { get; set; }
        public DuplicateFileModel DuplicateFile { get; set; }
        public int NumberOfChildren0To6 { get; set; }
        public int NumberOfChildren7To12 { get; set; }
        public int NumberOfChildren13To18 { get; set; }
        public StatusOfFileModel StatusOfFile { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastTransferred { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReOpened { get; set; }
    }
}
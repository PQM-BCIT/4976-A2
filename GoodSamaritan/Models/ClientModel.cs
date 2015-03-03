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
        public FiscalYear FiscalYear { get; set; }

        [Range(1, 12, ErrorMessage = "Please enter a valid month (1 - 12)"]
        public int Month { get; set; }

        [Range(1,31, ErrorMessage = "Please enter a valid date (1-31)")]
        public int Day { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid surname (eg. 'Smith')")]
        public string Surname { get; set; }

        [RegularExpression("/^[A-Z][a-z]*$/", ErrorMessage = "Please enter a valid first name (eg. 'James')")]
        public string FirstName { get; set; }

        public string PoliceFileNumber { get; set; }
        public int CourtFileNumber { get; set; }
        public RiskLevel RiskLevel { get; set; }
        public Crisis Crisis { get; set; }
        public Service Service { get; set; }
        public Program Program { get; set; }
        public string RiskAssessmentAssignedTo { get; set; }
        public RiskStatus RiskStatus { get; set; }
        public AssignedWorker AssignedWorker { get; set; }
        public ReferralSource ReferralSource { get; set; }
        public Incident Incident { get; set; }
        public string AbuserSurnameFirstName { get; set; }
        public AbuserRealtionship AbuserRealtionship { get; set; }
        public VictimOfIncident VictimOfIncident { get; set; }
        public FamilyViolenceFile FamilyViolenceFile { get; set; }
        public char Gender { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public Age Age { get; set; }
        public RepeatClient RepeatClient { get; set; }
        public DuplicateFile DuplicateFile { get; set; }
        public int NumberOfChildren0To6 { get; set; }
        public int NumberOfChildren7To12 { get; set; }
        public int NumberOfChildren13To18 { get; set; }
        public StatusOfFile StatusOfFile { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastTransferred { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReOpened { get; set; }
    }
}
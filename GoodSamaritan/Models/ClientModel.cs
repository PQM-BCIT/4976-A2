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
        public int Month { get; set; }
        public int Day { get; set; }
        public string Surname { get; set; }
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
        public DateTime DateLastTransferred { get; set; }
        public DateTime DateClosed { get; set; }
        public DateTime DateReOpened { get; set; }
    }
}
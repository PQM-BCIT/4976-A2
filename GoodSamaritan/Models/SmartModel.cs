using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class SmartModel
    {
        [Key]
        public int ClientReferenceNumber { get; set; }

        public SexWorkerExploitationModel SexWorkerExploitation { get; set; }

        public MultiplePerpetratorsModel MultiplePerpetrators { get; set; }

        public DrugFacilitatedAssaultModel DrugFacilitatedAssault { get; set; }

        public CityOfAssaultModel CityOfAssault { get; set; }

        public CityOfResidenceModel CityOfResidence { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer number")]
        public int AccompanimentMinute { get; set; }
        
        public ReferringHospitalModel ReferringHospital { get; set; }

        public HospitalAttendedModel HospitalAttended { get; set; }

        public SocialWorkAttendanceModel SocialWorkAttendance { get; set; }

        public PoliceAttendanceModel PoliceAttendance { get; set; }

        public VictimServicesAttendanceModel VictimServicesAttendance { get; set; }

        public MedicalOnlyModel MedicalOnly { get; set; }

        public EvidenceStoredModel EvidenceStored { get; set; }

        public HIVMedsModel HIVMeds { get; set; }

        public ReferredToCBVSModel ReferredToCBVS { get; set; }

        public PoliceReportedModel PoliceReported { get; set; }

        public ThirdPartyReportModel ThirdPartyReport { get; set; }

        public BadDateReportModel BadDateReport { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer number")]
        public int NumberTransportsProvided { get; set; }

        public bool ReferredToNursePractitioner { get; set; }
    }
}

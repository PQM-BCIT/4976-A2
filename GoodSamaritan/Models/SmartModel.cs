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

        [ForeignKey("SexWorkExploitation")]
        public int SexWorkerExploitationId { get; set; }
        public SexWorkerExploitationModel SexWorkExploitation { get; set; }

        [ForeignKey("MultiplePerpetrators")]
        public int MultiplePerpetratorsId { get; set; }
        public MultiplePerpetratorsModel MultiplePerpetrators { get; set; }

        [ForeignKey("DrugFacilitatedAssault")]
        public int DrugFacilitatedAssaultId { get; set; }
        public DrugFacilitatedAssaultModel DrugFacilitatedAssault { get; set; }

        [ForeignKey("CityOfAssault")]
        public int CityOfAssaultId { get; set; }
        public CityOfAssaultModel CityOfAssault { get; set; }

        [ForeignKey("CityOfResidence")]
        public int CityOfResidenceId { get; set; }
        public CityOfResidenceModel CityOfResidence { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer number")]
        public int AccompanimentMinute { get; set; }

        [ForeignKey("ReferringHospital")]
        public int ReferringHospitalId { get; set; }
        public ReferringHospitalModel ReferringHospital { get; set; }

        [ForeignKey("HospitalAttended")]
        public int HospitalAttendedId { get; set; }
        public HospitalAttendedModel HospitalAttended { get; set; }

        [ForeignKey("SocialWorkAttendance")]
        public int SocialWorkAttendanceId { get; set; }
        public SocialWorkAttendanceModel SocialWorkAttendance { get; set; }

        [ForeignKey("PoliceAttendance")]
        public int PoliceAttendanceId { get; set; }
        public PoliceAttendanceModel PoliceAttendance { get; set; }

        [ForeignKey("VictimServicesAttendance")]
        public int VictimServicesAttendanceId { get; set; }
        public VictimServicesAttendanceModel VictimServicesAttendance { get; set; }

        [ForeignKey("MedicalOnly")]
        public int MedicalOnlyId { get; set; }
        public MedicalOnlyModel MedicalOnly { get; set; }

        [ForeignKey("EvidenceStored")]
        public int EvidenceStoredId { get; set; }
        public EvidenceStoredModel EvidenceStored { get; set; }

        [ForeignKey("HIVMeds")]
        public int HIVMedsModelId { get; set; }
        public HIVMedsModel HIVMeds { get; set; }

        [ForeignKey("ReferredToCBVS")]
        public int ReferredToCBVSId { get; set; }
        public ReferredToCBVSModel ReferredToCBVS { get; set; }

        [ForeignKey("PoliceReported")]
        public int PoliceReportedId { get; set; }
        public PoliceReportedModel PoliceReported { get; set; }

        [ForeignKey("ThirdPartyReport")]
        public int ThirdPartyReportId { get; set; }
        public ThirdPartyReportModel ThirdPartyReport { get; set; }

        [ForeignKey("BadDateReport")]
        public int BadDateReportId { get; set; }
        public BadDateReportModel BadDateReport { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer number")]
        public int NumberTransportsProvided { get; set; }

        public bool ReferredToNursePractitioner { get; set; }
    }
}

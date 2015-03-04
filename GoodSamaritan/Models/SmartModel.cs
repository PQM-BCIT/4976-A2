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
        public SexWorkExploitation SexWorkerExploitation { get; set; }

        [ForeignKey("MultiplePerpetrators")]
        public MultiplePerpetrators MultiplePerpetrators { get; set; }

        [ForeignKey("DrugFacilitatedAssut")]
        public DrugFacilitatedAssault DrugFacilitatedAssault { get; set; }

        [ForeignKey("CityOfAssault")]
        public CityOfAssault CityOfAssault { get; set; }

        [ForeignKey("CityOfResidence")]
        public CityOfResidence CityOfResidence { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer number")]
        public int AccompanimentMinute { get; set; }
        
        [ForeignKey("ReferringHospital")]
        public ReferringHospital ReferringHospital { get; set; }

        [ForeignKey("HospitalAttended")]
        public HospitalAttended HospitalAttended { get; set; }

        [ForeignKey("SocialWorkAttendance")]
        public SocialWorkAttendance SocialWorkAttendance { get; set; }

        [ForeignKey("PoliceAttendance")]
        public PoliceAttendance PoliceAttendance { get; set; }

        [ForeignKey("VictimServicesAttendance")]
        public VictimServicesAttendance VictimServicesAttendance { get; set; }

        [ForeignKey("MedicalOnly")]
        public MedicalOnly MedicalOnly { get; set; }

        [ForeignKey("EvidenceStored")]
        public EvidenceStored EvidenceStored { get; set; }

        [ForeignKey("HIVMeds")]
        public HIVMeds HIVMeds { get; set; }

        [ForeignKey("ReferrdToCBVS")]
        public ReferredToCBVS ReferredToCBVS { get; set; }

        [ForeignKey("PoliceReported")]
        public PoliceReported PoliceReported { get; set; }

        [ForeignKey("ThirdPartReport")]
        public ThirdPartyReport ThirdPartyReport { get; set; }

        [ForeignKey("BadDateReport")]
        public BadDateReport BadDateReport { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer number")]
        public int NumberTransportsProvided { get; set; }

        public bool ReferredToNursePractitioner { get; set; }
    }
}

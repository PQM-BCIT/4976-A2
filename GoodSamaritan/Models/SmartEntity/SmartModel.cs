using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class SmartModel
    {
        [Key]
        public int ClientReferenceNumber { get; set; }
        public SexWorkExploitation SexWorkerExploitation { get; set; }
        public MultiplePerpetrators MultiplePerpetrators { get; set; }
        public DrugFacilitatedAssault DrugFacilitatedAssault { get; set; }
        public CityOfAssault CityOfAssault { get; set; }
        public CityOfResidence CityOfResidence { get; set; }
        public int AccompanimentMinute { get; set; }
        public ReferringHospital ReferringHospital { get; set; }
        public HospitalAttended HospitalAttended { get; set; }
        public SocialWorkAttendance SocialWorkAttendance { get; set; }
        public PoliceAttendance PoliceAttendance { get; set; }
        public VictimServicesAttendance VictimServicesAttentance { get; set; }
        public MedicalOnly MedicalOnly { get; set; }
        public EvidenceStored EvidenceStored { get; set; }
        public HIVMeds HIVMeds { get; set; }
        public ReferredToCBVS ReferredToCBVS { get; set; }
        public PoliceReported PoliceReported { get; set; }
        public ThirdPartyReport ThirdPartyReport { get; set; }
        public BadDateReport BadDateReport { get; set; }
        public int NumberTransportsProvided { get; set; }
        public bool ReferredToNursePractitioner { get; set; }
    }
}

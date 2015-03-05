using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class VictimServicesAttendanceModel
    {
        // Yes; No; N/A
        [Key]
        public int VictimServicesAttendanceId { get; set; }
        public string VictimServicesAttendance { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
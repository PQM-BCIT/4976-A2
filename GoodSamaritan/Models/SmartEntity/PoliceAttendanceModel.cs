using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class PoliceAttendanceModel
    {
        // Yes; No; N/A
        [Key]
        public int PoliceAttendanceId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Police Attendance")]
        public string PoliceAttendance { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
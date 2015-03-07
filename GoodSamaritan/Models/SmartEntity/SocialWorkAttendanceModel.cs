using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class SocialWorkAttendanceModel
    {
        // Yes; No; N/A
        [Key]
        public int SocialWorkAttendanceId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Social Work Attendance")]
        public string SocialWorkAttendance { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
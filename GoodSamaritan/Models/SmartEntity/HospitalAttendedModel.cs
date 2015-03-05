using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class HospitalAttendedModel
    {
        [Key]
        public int HospitalAttendedId { get; set; }
        public string HospitalAttended { get; set; }

        public List<SmartModel> List { get; set; }
    }
}
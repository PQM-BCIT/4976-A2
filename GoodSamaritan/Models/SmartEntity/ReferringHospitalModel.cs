using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class ReferringHospitalModel
    {
        [Key]
        public int ReferringHospitalId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Refferring Hospital")]
        public string ReferringHospital { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
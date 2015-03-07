using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class MedicalOnlyModel
    {
        // Yes; No; N/A
        [Key]
        public int MedicalOnlyId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Medical Only")]
        public string MedicalOnly { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
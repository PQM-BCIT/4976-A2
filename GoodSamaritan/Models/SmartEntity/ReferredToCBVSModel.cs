using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class ReferredToCBVSModel
    {
        // Yes; No; PVBS Only; N/A
        [Key]
        public int ReferredToCBVSId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Referred to CBVS")]
        public string ReferredToCBVS { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
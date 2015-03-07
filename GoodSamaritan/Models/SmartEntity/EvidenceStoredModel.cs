using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class EvidenceStoredModel
    {
        // Yes; No; N/A
        [Key]
        public int EvidenceStoredId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Evidence Stored")]
        public string EvidenceStored { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
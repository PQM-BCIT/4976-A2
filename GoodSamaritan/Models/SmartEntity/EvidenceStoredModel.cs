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
        public string EvidenceStored { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
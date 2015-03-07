using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class ThirdPartyReportModel
    {
        // Yes; No; N/A
        [Key]
        public int ThirdPartyReportId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Third Party Report")]
        public string ThirdPartyReport { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
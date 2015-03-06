using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class BadDateReportModel
    {
        // Yes; No; N/A
        [Key]
        public int BadDateReportId { get; set; }
        public string BadDateReport { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
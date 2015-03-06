﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class PoliceReportedModel
    {
        // Yes; No; N/A
        [Key]
        public int PoliceReportedId { get; set; }
        public string PoliceReported { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
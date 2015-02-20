﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class MedicalOnly
    {
        // Yes; No; N/A
        [Key]
        public string Status { get; set; }

        public List<SmartEntity> SmartEntity { get; set; }
    }
}
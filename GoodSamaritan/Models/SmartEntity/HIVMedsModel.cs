﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class HIVMedsModel
    {
        // Yes; No; N/A
        [Key]
        public int HIVMedsId { get; set; }
        public string HIVMeds { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
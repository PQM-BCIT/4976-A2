using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class ReferredToCBVS
    {
        // Yes; No; PVBS Only; N/A
        [Key]
        public string Status { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
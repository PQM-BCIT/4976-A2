using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class DrugFacilitatedAssaultModel
    {
        // Yes; No; N/A
        [Key]
        public int DrugFacilitatedAssaultId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Drug Facilitated Assault")]
        public string DrugFacilitatedAssault { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
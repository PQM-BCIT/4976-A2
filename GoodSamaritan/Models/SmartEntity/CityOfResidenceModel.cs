using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class CityOfResidenceModel
    {
        [Key]
        public int CityOfResidenceId { get; set; }

        [MaxLength(64)]
        [Display(Name = "City Of Residence")]
        public string CityOfResidence { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
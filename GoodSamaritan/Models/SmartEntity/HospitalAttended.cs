using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class HospitalAttended
    {
        [Key]
        public string Name { get; set; }

        public List<SmartModel> List { get; set; }
    }
}
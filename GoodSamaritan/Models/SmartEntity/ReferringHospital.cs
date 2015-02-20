using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class ReferringHospital
    {
        [Key]
        public string Name { get; set; }

        public List<SmartEntity> SmartEntity { get; set; }
    }
}
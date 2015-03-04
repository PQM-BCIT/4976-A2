using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.SmartEntity
{
    public class CityOfAssaultModel
    {
        [Key]
        public string CityOfAssault { get; set; }

        public List<SmartModel> SmartEntity { get; set; }
    }
}
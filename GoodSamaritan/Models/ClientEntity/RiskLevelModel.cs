using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class RiskLevelModel
    {
        [Key]
        public int RiskLevelId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Risk Level")]
        public string RiskLevel { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
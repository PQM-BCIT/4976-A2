using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class RiskStatusModel
    {
        [Key]
        public int RiskStatusId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Risk Status")]
        public string RiskStatus { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
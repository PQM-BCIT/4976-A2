using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class RiskStatus
    {
        [Key]
        public int RiskId { get; set; }
        public string RiskStats { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
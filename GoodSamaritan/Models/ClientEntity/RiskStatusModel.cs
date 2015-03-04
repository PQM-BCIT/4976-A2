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
        public string RiskStatus { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
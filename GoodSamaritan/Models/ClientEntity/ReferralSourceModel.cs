using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class ReferralSourceModel
    {
        [Key]
        public int ReferralSourceId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Referral Source")]
        public string ReferralSource { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
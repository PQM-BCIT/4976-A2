using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class ReferralContactModel
    {
        [Key]
        public int ReferralContactId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Referral Contact")]
        public string ReferralContact { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
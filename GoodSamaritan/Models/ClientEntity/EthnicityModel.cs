using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class EthnicityModel
    {
        [Key]
        public int EthnicityId { get; set; }

        [Required]
        [MaxLength(64)]
        [Display(Name ="Ethnicity")]
        public string Ethnicity { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
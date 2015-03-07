using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class AgeModel
    {
        [Key]
        public int AgeId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Age")]
        public string Age { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
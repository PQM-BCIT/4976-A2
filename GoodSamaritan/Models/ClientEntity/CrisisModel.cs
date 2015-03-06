using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class CrisisModel
    {
        [Key]
        public int CrisisId { get; set; }

        [Required]
        [MaxLength(64)]
        [Display(Name = "Crisis")]
        public string Crisis { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
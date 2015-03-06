using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class IncidentModel
    {
        [Key]
        public int IncidentId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Incident")]
        public string Incident { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class VictimOfIncidentModel
    {
        [Key]
        public int VictimOfIncidentId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Victim Of Incident")]
        public string VictimOfIncident { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
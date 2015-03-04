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
        public string VictimOfIncident { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
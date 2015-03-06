using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class ServiceModel
    {
        [Key]
        public int ServiceId { get; set; }
        public string Service { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
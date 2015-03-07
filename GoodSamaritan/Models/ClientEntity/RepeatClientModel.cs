using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class RepeatClientModel
    {
        [Key]
        public int RepeatClientId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Repeat Client")]
        public string RepeatClient { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
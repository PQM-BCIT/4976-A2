using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class AssignedWorker
    {
        [Key]
        public String AssignedWorker { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
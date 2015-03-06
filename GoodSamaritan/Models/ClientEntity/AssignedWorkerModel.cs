using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class AssignedWorkerModel
    {
        [Key]
        public int AssignedWorkerId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Assigned Worker")]
        public string AssignedWorker { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
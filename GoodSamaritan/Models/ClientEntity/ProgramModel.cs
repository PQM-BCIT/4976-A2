using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class ProgramModel
    {
        [Key]
        public int ProgramId { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Program")]
        public string Program { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class FiscalYearModel
    {
        [Key]
        [Display(Name = "Fiscal Year")]
        public int FiscalYearId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Fiscal Year")]
        public string FiscalYear { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
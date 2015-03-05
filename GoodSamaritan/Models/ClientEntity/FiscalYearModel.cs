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
        public int FiscalYearId { get; set; }
        public string FiscalYear { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
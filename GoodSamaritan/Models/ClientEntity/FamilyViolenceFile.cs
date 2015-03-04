using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class FamilyViolenceFile
    {
        [Key]
        public string FamilyViolenceFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
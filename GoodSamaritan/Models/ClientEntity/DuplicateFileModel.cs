using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class DuplicateFileModel
    {
        [Key]
        public int DuplicateFileId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Duplicate File")]
        public string DuplicateFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
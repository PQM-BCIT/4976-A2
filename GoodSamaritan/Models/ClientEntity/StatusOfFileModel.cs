﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class StatusOfFileModel
    {
        [Key]
        public int StatusOfFileId { get; set; }

        [MaxLength(64)]
        [Display(Name = "Status Of File")]
        public string StatusOfFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
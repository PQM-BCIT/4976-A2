﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.ClientEntity
{
    public class AbuserRelationshipModel
    {
        [Key]
        public int AbuserRelationshipId { get; set; }
        public string AbuserRelationship { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}
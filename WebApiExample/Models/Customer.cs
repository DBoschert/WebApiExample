﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExample.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Code { get; set; } = String.Empty;
        [StringLength(30)]
        public string Name { get; set; } = String.Empty;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponEntities.Entity
{
    [Table("Sword")]
    public class Sword
    {
        public int SwordId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public decimal Attack { get; set; }
        public decimal Shield { get; set; }
        public int EnchantmentId { get; set; }

        [ForeignKey("EnchantmentId")]
        public Enchantment Enchantment { get; set; }
    }
}
/*
Sword
SwordId (int)
Name (string)
Attack (Decimal)
Shield (Decimal)
EchantmentId (int)
*/
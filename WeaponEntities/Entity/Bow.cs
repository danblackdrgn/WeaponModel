﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponEntities.Entity
{
    [Table("Bow")]
    public class Bow
    {
        public int BowId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public decimal Attack { get; set; }
        public int Range { get; set; }
        public int Ammo { get; set; }
        public int EnchantmentId { get; set; }

        [ForeignKey("EnchantmentId")]
        public Enchantment Enchantment { get; set; }
    }
}
/*
 Bow
BowId (int)
Name (string)
Attack (Decimal)
Range (int) 
Ammo (int)
EchantmentId (int)
*/
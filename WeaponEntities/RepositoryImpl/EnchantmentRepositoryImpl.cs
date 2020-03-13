using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponEntities.Entity;
using WeaponEntities.Repository;

namespace WeaponEntities.RepositoryImpl
{
    public class EnchantmentRepositoryImpl : IEnchantmentRepository
    {
        public ICollection<Enchantment> GetAllEnchantmentByElement(string Element)
        {
            using (WeaponDb db = new WeaponDb())
            {
                var EnchantmentList = db.Enchantments.Where(e => e.Element == Element).ToList<Enchantment>();
                return EnchantmentList;
            }
        }
        // tam adre wey
        public ICollection<Enchantment> GetAllEnchantmentByLevel(int Level)
        {
            using ( WeaponDb db = new WeaponDb())
            {
                var EnchantmentList = db.Enchantments.Where(e => e.Level == Level).ToList<Enchantment>();
                return EnchantmentList;
            }
        }

        public Enchantment GetEnchantmentById(int Id)
        {
            using (WeaponDb db = new WeaponDb())
            {
                var enchantmentItem = db.Enchantments.Where(e => e.EnchantmentId == Id).FirstOrDefault();
                return enchantmentItem;
            }
        }
    }
}

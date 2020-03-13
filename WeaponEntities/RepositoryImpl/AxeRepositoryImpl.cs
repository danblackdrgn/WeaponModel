using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponEntities.Entity;
using WeaponEntities.Repository;

namespace WeaponEntities.RepositoryImpl
{
    public class AxeRepositoryImpl : IAxeRepository
    {
        IEnchantmentRepository enchantmentRepository;
        
        public AxeRepositoryImpl()
        {
            enchantmentRepository = new EnchantmentRepositoryImpl();
        }
        public bool AddAxe(Axe AxeItem)
        {
            
                if (AxeItem != null)
                {
                    using (WeaponDb db = new WeaponDb()) 
                        {
                            db.Axes.Add(AxeItem);
                            db.SaveChanges();
                            return true;
                        }
                }
                return false;
        }

        public bool DeleteAxe(int AxeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Axe> GetAllAxes()
        {
            using (WeaponDb db = new WeaponDb())
            {
                var axes =  db.Axes.ToList<Axe>();
                foreach (var axe in axes)
                {
                    axe.Enchantment =  enchantmentRepository.GetEnchantmentById(axe.EnchantmentId);
                }
                return axes;
            }
        }

        public ICollection<Axe> GetAllAxesByEnchantment(int EnchantmentId)
        {
            throw new NotImplementedException();
        }

        public Axe GetAxeByName(string AxeName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAxe(int AxeId)
        {
            throw new NotImplementedException();
        }
    }
}
